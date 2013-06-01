using Tw.Com.Iisi.LogAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.Text;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///這是 AnalysisTest 的測試類別，應該包含
    ///所有 AnalysisTest 單元測試
    ///</summary>
    [TestClass()]
    public class AnalysisTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///取得或設定提供目前測試回合的相關資訊與功能
        ///的測試內容。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 其他測試屬性
        // 
        //您可以在撰寫測試時，使用下列的其他屬性:
        //
        //在執行類別中的第一項測試之前，先使用 ClassInitialize 執行程式碼
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //在執行類別中的所有測試之後，使用 ClassCleanup 執行程式碼
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //在執行每一項測試之前，先使用 TestInitialize 執行程式碼
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //在執行每一項測試之後，使用 TestCleanup 執行程式碼
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///SetText 的測試
        ///</summary>
        [TestMethod()]
        [DeploymentItem("LogAnalysis.exe")]
        public void SetTextTest()
        {
            PrivateObject param0 = null; // TODO: 初始化為適當值
            Analysis_Accessor target = new Analysis_Accessor(param0); // TODO: 初始化為適當值
            Dictionary<TextBox, StringBuilder> textTmp = null; // TODO: 初始化為適當值
            TextBox textBox = null; // TODO: 初始化為適當值
            string str = string.Empty; // TODO: 初始化為適當值
            target.SetText(textTmp, textBox, str);
            Assert.Inconclusive("無法驗證不傳回值的方法。");
        }
    }
}
