using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']"
	[global::Android.Runtime.Register ("com/tencent/open/utils/ServerSetting", DoNotGenerateAcw=true)]
	public partial class ServerSetting : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='APP_DETAIL_PAGE']"
		[Register ("APP_DETAIL_PAGE")]
		public const string AppDetailPage = (string) "http://fusion.qq.com/cgi-bin/qzapps/unified_jump?appid=%1$s&from=%2$s&isOpenAppID=1";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='CGI_FETCH_QQ_URL']"
		[Register ("CGI_FETCH_QQ_URL")]
		public const string CgiFetchQqUrl = (string) "http://fusion.qq.com/cgi-bin/qzapps/mapp_getappinfo.cgi";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='DEFAULT_CGI_AUTHORIZE']"
		[Register ("DEFAULT_CGI_AUTHORIZE")]
		public const string DefaultCgiAuthorize = (string) "http://openmobile.qq.com/oauth2.0/m_authorize?";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='DEFAULT_LOCAL_STORAGE_URI']"
		[Register ("DEFAULT_LOCAL_STORAGE_URI")]
		public const string DefaultLocalStorageUri = (string) "http://qzs.qq.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='DEFAULT_REDIRECT_URI']"
		[Register ("DEFAULT_REDIRECT_URI")]
		public const string DefaultRedirectUri = (string) "auth://tauth.qq.com/";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='DEFAULT_URL_ASK']"
		[Register ("DEFAULT_URL_ASK")]
		public const string DefaultUrlAsk = (string) "http://qzs.qq.com/open/mobile/request/sdk_request.html?";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='DEFAULT_URL_BRAG']"
		[Register ("DEFAULT_URL_BRAG")]
		public const string DefaultUrlBrag = (string) "http://qzs.qq.com/open/mobile/brag/sdk_brag.html?";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='DEFAULT_URL_GIFT']"
		[Register ("DEFAULT_URL_GIFT")]
		public const string DefaultUrlGift = (string) "http://qzs.qq.com/open/mobile/request/sdk_request.html?";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='DEFAULT_URL_GRAPH_BASE']"
		[Register ("DEFAULT_URL_GRAPH_BASE")]
		public const string DefaultUrlGraphBase = (string) "https://openmobile.qq.com/";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='DEFAULT_URL_INVITE']"
		[Register ("DEFAULT_URL_INVITE")]
		public const string DefaultUrlInvite = (string) "http://qzs.qq.com/open/mobile/invite/sdk_invite.html?";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='DEFAULT_URL_REACTIVE']"
		[Register ("DEFAULT_URL_REACTIVE")]
		public const string DefaultUrlReactive = (string) "http://qzs.qq.com/open/mobile/reactive/sdk_reactive.html?";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='DEFAULT_URL_REPORT']"
		[Register ("DEFAULT_URL_REPORT")]
		public const string DefaultUrlReport = (string) "http://wspeed.qq.com/w.cgi";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='DEFAULT_URL_SEND_STORY']"
		[Register ("DEFAULT_URL_SEND_STORY")]
		public const string DefaultUrlSendStory = (string) "http://qzs.qq.com/open/mobile/sendstory/sdk_sendstory_v1.3.html?";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='DEFAULT_URL_VOICE']"
		[Register ("DEFAULT_URL_VOICE")]
		public const string DefaultUrlVoice = (string) "http://qzs.qq.com/open/mobile/not_support.html?";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='DOWNLOAD_QQ_URL']"
		[Register ("DOWNLOAD_QQ_URL")]
		public const string DownloadQqUrl = (string) "http://qzs.qq.com/open/mobile/login/qzsjump.html?";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='DOWNLOAD_QQ_URL_COMMON']"
		[Register ("DOWNLOAD_QQ_URL_COMMON")]
		public const string DownloadQqUrlCommon = (string) "http://qzs.qq.com/open/mobile/sdk_common/down_qq.htm?";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='ENVIRONMENT_EXPERIENCE']"
		[Register ("ENVIRONMENT_EXPERIENCE")]
		public const int EnvironmentExperience = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='ENVIRONMENT_NORMOL']"
		[Register ("ENVIRONMENT_NORMOL")]
		public const int EnvironmentNormol = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='KEY_HOST_ANALY']"
		[Register ("KEY_HOST_ANALY")]
		public const string KeyHostAnaly = (string) "analy.qq.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='KEY_HOST_APPIC']"
		[Register ("KEY_HOST_APPIC")]
		public const string KeyHostAppic = (string) "appic.qq.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='KEY_HOST_APP_SUPPORT']"
		[Register ("KEY_HOST_APP_SUPPORT")]
		public const string KeyHostAppSupport = (string) "appsupport.qq.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='KEY_HOST_FUSION']"
		[Register ("KEY_HOST_FUSION")]
		public const string KeyHostFusion = (string) "fusion.qq.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='KEY_HOST_I_GTIMG']"
		[Register ("KEY_HOST_I_GTIMG")]
		public const string KeyHostIGtimg = (string) "i.gtimg.cn";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='KEY_HOST_MAPP_QZONE']"
		[Register ("KEY_HOST_MAPP_QZONE")]
		public const string KeyHostMappQzone = (string) "mapp.qzone.qq.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='KEY_HOST_OPEN_MOBILE']"
		[Register ("KEY_HOST_OPEN_MOBILE")]
		public const string KeyHostOpenMobile = (string) "openmobile.qq.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='KEY_HOST_QZAPP_QLOGO']"
		[Register ("KEY_HOST_QZAPP_QLOGO")]
		public const string KeyHostQzappQlogo = (string) "qzapp.qlogo.cn";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='KEY_HOST_QZS_QQ']"
		[Register ("KEY_HOST_QZS_QQ")]
		public const string KeyHostQzsQq = (string) "qzs.qq.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='KEY_OPEN_ENV']"
		[Register ("KEY_OPEN_ENV")]
		public const string KeyOpenEnv = (string) "OpenEnvironment";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='KEY_OPEN_SETTING']"
		[Register ("KEY_OPEN_SETTING")]
		public const string KeyOpenSetting = (string) "OpenSettings";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='NEED_QQ_VERSION_TIPS_URL']"
		[Register ("NEED_QQ_VERSION_TIPS_URL")]
		public const string NeedQqVersionTipsUrl = (string) "http://openmobile.qq.com/oauth2.0/m_jump_by_version?";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='URL_FUSION_BASE']"
		[Register ("URL_FUSION_BASE")]
		public const string UrlFusionBase = (string) "http://fusion.qq.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='URL_FUSION_CGI_BASE']"
		[Register ("URL_FUSION_CGI_BASE")]
		public const string UrlFusionCgiBase = (string) "http://fusion.qq.com/cgi-bin";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='URL_PRIZE_EXCHANGE']"
		[Register ("URL_PRIZE_EXCHANGE")]
		public const string UrlPrizeExchange = (string) "http://fusion.qq.com/cgi-bin/prize_sharing/exchange_prize.cgi";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='URL_PRIZE_GET_ACTIVITY_STATE']"
		[Register ("URL_PRIZE_GET_ACTIVITY_STATE")]
		public const string UrlPrizeGetActivityState = (string) "http://fusion.qq.com/cgi-bin/prize_sharing/get_activity_state.cgi";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='URL_PRIZE_MAKE_SHARE_URL']"
		[Register ("URL_PRIZE_MAKE_SHARE_URL")]
		public const string UrlPrizeMakeShareUrl = (string) "http://fusion.qq.com/cgi-bin/prize_sharing/make_share_url.cgi";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/field[@name='URL_PRIZE_QUERY_UNEXCHANGE']"
		[Register ("URL_PRIZE_QUERY_UNEXCHANGE")]
		public const string UrlPrizeQueryUnexchange = (string) "http://fusion.qq.com/cgi-bin/prize_sharing/query_unexchange_prize.cgi";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/utils/ServerSetting", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ServerSetting); }
		}

		protected ServerSetting (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/constructor[@name='ServerSetting' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ServerSetting ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ServerSetting)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Tencent.Open.Utils.ServerSetting Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/tencent/open/utils/ServerSetting;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/tencent/open/utils/ServerSetting;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Utils.ServerSetting> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_changeServer;
#pragma warning disable 0169
		static Delegate GetChangeServerHandler ()
		{
			if (cb_changeServer == null)
				cb_changeServer = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ChangeServer);
			return cb_changeServer;
		}

		static void n_ChangeServer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Utils.ServerSetting __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Utils.ServerSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ChangeServer ();
		}
#pragma warning restore 0169

		static IntPtr id_changeServer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/method[@name='changeServer' and count(parameter)=0]"
		[Register ("changeServer", "()V", "GetChangeServerHandler")]
		public virtual unsafe void ChangeServer ()
		{
			if (id_changeServer == IntPtr.Zero)
				id_changeServer = JNIEnv.GetMethodID (class_ref, "changeServer", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_changeServer);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "changeServer", "()V"));
			} finally {
			}
		}

		static Delegate cb_getEnvUrl_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetEnvUrl_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_getEnvUrl_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_getEnvUrl_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetEnvUrl_Landroid_content_Context_Ljava_lang_String_);
			return cb_getEnvUrl_Landroid_content_Context_Ljava_lang_String_;
		}

		static IntPtr n_GetEnvUrl_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Open.Utils.ServerSetting __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Utils.ServerSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetEnvUrl (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getEnvUrl_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/method[@name='getEnvUrl' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getEnvUrl", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "GetGetEnvUrl_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe string GetEnvUrl (global::Android.Content.Context p0, string p1)
		{
			if (id_getEnvUrl_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getEnvUrl_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getEnvUrl", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEnvUrl_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEnvUrl", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setEnvironment_Landroid_content_Context_I;
#pragma warning disable 0169
		static Delegate GetSetEnvironment_Landroid_content_Context_IHandler ()
		{
			if (cb_setEnvironment_Landroid_content_Context_I == null)
				cb_setEnvironment_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetEnvironment_Landroid_content_Context_I);
			return cb_setEnvironment_Landroid_content_Context_I;
		}

		static void n_SetEnvironment_Landroid_content_Context_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Tencent.Open.Utils.ServerSetting __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Utils.ServerSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetEnvironment (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setEnvironment_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ServerSetting']/method[@name='setEnvironment' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("setEnvironment", "(Landroid/content/Context;I)V", "GetSetEnvironment_Landroid_content_Context_IHandler")]
		public virtual unsafe void SetEnvironment (global::Android.Content.Context p0, int p1)
		{
			if (id_setEnvironment_Landroid_content_Context_I == IntPtr.Zero)
				id_setEnvironment_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "setEnvironment", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setEnvironment_Landroid_content_Context_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnvironment", "(Landroid/content/Context;I)V"), __args);
			} finally {
			}
		}

	}
}
