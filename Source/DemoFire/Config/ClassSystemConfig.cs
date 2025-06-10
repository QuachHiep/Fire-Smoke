using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DKVN;
using DemoFire;


namespace DKVN
{
    public class ClassSystemConfig
    {
        #region Singleton
        private static readonly Lazy<ClassSystemConfig> _cInstance = new Lazy<ClassSystemConfig>(() => new ClassSystemConfig());
        public static ClassSystemConfig Ins { get { return _cInstance.Value ; } }
        #endregion

        public ClassSystemConfig()
        {
            m_ClsCommon = new ClassCommon();
            m_ClsFunc = new ClassFunction();

            m_FrmLoading = new FormLoading();
            m_UserDisplay = new List<UserCtrlDisplay[]>(20);
            m_FrmLogin = new FormLogIn();
            m_FrmSetting = new FormSetting();
            m_CameraList = new FormCameraList();
            m_SettingParam = new MeasureRecipe2();
            m_FrmParamCamera = new FormParamCamera();
            m_FrmLogView = new FormLogView();
            //VDKFrame.DKLicense.Licensing.PairLicense("CEa2S.MD3qD.HP4lK.G25fc");
        }

        #region Define Form Varibales
        public FormLoading m_FrmLoading;
        public FormStartupLoading m_FrmStartLoad;
        public List<UserCtrlDisplay[]> m_UserDisplay;
        public FormLogIn m_FrmLogin;
        public FormSetting m_FrmSetting;
        public FormCameraList m_CameraList;
        public MeasureRecipe2 m_SettingParam;
        public FormParamCamera m_FrmParamCamera;
        public FormLogView m_FrmLogView;
        #endregion

        #region Config Varibales
        public ClassCommon m_ClsCommon;
        public ClassFunction m_ClsFunc;
        
        #endregion
    }
}
