using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']"
	[global::Android.Runtime.Register ("com/tencent/open/utils/SystemUtils", DoNotGenerateAcw=true)]
	public partial class SystemUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/field[@name='ACTION_LOGIN']"
		[Register ("ACTION_LOGIN")]
		public const string ActionLogin = (string) "action_login";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/field[@name='ACTION_REQUEST_API']"
		[Register ("ACTION_REQUEST_API")]
		public const string ActionRequestApi = (string) "action_request";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/field[@name='ACTION_SHARE']"
		[Register ("ACTION_SHARE")]
		public const string ActionShare = (string) "action_share";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/field[@name='H5_SHARE_DATA']"
		[Register ("H5_SHARE_DATA")]
		public const string H5ShareData = (string) "h5_share_data";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/field[@name='IS_LOGIN']"
		[Register ("IS_LOGIN")]
		public const string IsLogin = (string) "is_login";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/field[@name='IS_QQ_MOBILE_SHARE']"
		[Register ("IS_QQ_MOBILE_SHARE")]
		public const string IsQqMobileShare = (string) "is_qq_mobile_share";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/field[@name='QQDATALINE_CALLBACK_ACTION']"
		[Register ("QQDATALINE_CALLBACK_ACTION")]
		public const string QqdatalineCallbackAction = (string) "sendToMyComputer";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/field[@name='QQFAVORITES_CALLBACK_ACTION']"
		[Register ("QQFAVORITES_CALLBACK_ACTION")]
		public const string QqfavoritesCallbackAction = (string) "addToQQFavorites";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/field[@name='QQ_SHARE_CALLBACK_ACTION']"
		[Register ("QQ_SHARE_CALLBACK_ACTION")]
		public const string QqShareCallbackAction = (string) "shareToQQ";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/field[@name='QQ_VERSION_NAME_4_2_0']"
		[Register ("QQ_VERSION_NAME_4_2_0")]
		public const string QqVersionName420 = (string) "4.2.0";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/field[@name='QQ_VERSION_NAME_4_3_0']"
		[Register ("QQ_VERSION_NAME_4_3_0")]
		public const string QqVersionName430 = (string) "4.3.0";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/field[@name='QQ_VERSION_NAME_4_5_0']"
		[Register ("QQ_VERSION_NAME_4_5_0")]
		public const string QqVersionName450 = (string) "4.5.0";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/field[@name='QQ_VERSION_NAME_4_6_0']"
		[Register ("QQ_VERSION_NAME_4_6_0")]
		public const string QqVersionName460 = (string) "4.6.0";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/field[@name='QQ_VERSION_NAME_5_0_0']"
		[Register ("QQ_VERSION_NAME_5_0_0")]
		public const string QqVersionName500 = (string) "5.0.0";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/field[@name='QQ_VERSION_NAME_5_1_0']"
		[Register ("QQ_VERSION_NAME_5_1_0")]
		public const string QqVersionName510 = (string) "5.1.0";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/field[@name='QQ_VERSION_NAME_5_2_0']"
		[Register ("QQ_VERSION_NAME_5_2_0")]
		public const string QqVersionName520 = (string) "5.2.0";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/field[@name='QQ_VERSION_NAME_5_3_0']"
		[Register ("QQ_VERSION_NAME_5_3_0")]
		public const string QqVersionName530 = (string) "5.3.0";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/field[@name='QZONE_SHARE_CALLBACK_ACTION']"
		[Register ("QZONE_SHARE_CALLBACK_ACTION")]
		public const string QzoneShareCallbackAction = (string) "shareToQzone";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/field[@name='TROOPBAR_CALLBACK_ACTION']"
		[Register ("TROOPBAR_CALLBACK_ACTION")]
		public const string TroopbarCallbackAction = (string) "shareToTroopBar";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/utils/SystemUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SystemUtils); }
		}

		protected SystemUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/constructor[@name='SystemUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SystemUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SystemUtils)) {
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

		static IntPtr id_getAndroidSDKVersion;
		public static unsafe int AndroidSDKVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/method[@name='getAndroidSDKVersion' and count(parameter)=0]"
			[Register ("getAndroidSDKVersion", "()I", "GetGetAndroidSDKVersionHandler")]
			get {
				if (id_getAndroidSDKVersion == IntPtr.Zero)
					id_getAndroidSDKVersion = JNIEnv.GetStaticMethodID (class_ref, "getAndroidSDKVersion", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getAndroidSDKVersion);
				} finally {
				}
			}
		}

		static IntPtr id_isSupportMultiTouch;
		public static unsafe bool IsSupportMultiTouch {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/method[@name='isSupportMultiTouch' and count(parameter)=0]"
			[Register ("isSupportMultiTouch", "()Z", "GetIsSupportMultiTouchHandler")]
			get {
				if (id_isSupportMultiTouch == IntPtr.Zero)
					id_isSupportMultiTouch = JNIEnv.GetStaticMethodID (class_ref, "isSupportMultiTouch", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSupportMultiTouch);
				} finally {
				}
			}
		}

		static IntPtr id_isX86Architecture;
		public static unsafe bool IsX86Architecture {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/method[@name='isX86Architecture' and count(parameter)=0]"
			[Register ("isX86Architecture", "()Z", "GetIsX86ArchitectureHandler")]
			get {
				if (id_isX86Architecture == IntPtr.Zero)
					id_isX86Architecture = JNIEnv.GetStaticMethodID (class_ref, "isX86Architecture", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isX86Architecture);
				} finally {
				}
			}
		}

		static IntPtr id_checkMobileQQ_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/method[@name='checkMobileQQ' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkMobileQQ", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool CheckMobileQQ (global::Android.Content.Context p0)
		{
			if (id_checkMobileQQ_Landroid_content_Context_ == IntPtr.Zero)
				id_checkMobileQQ_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkMobileQQ", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkMobileQQ_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_compareQQVersion_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/method[@name='compareQQVersion' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("compareQQVersion", "(Landroid/content/Context;Ljava/lang/String;)I", "")]
		public static unsafe int CompareQQVersion (global::Android.Content.Context p0, string p1)
		{
			if (id_compareQQVersion_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_compareQQVersion_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "compareQQVersion", "(Landroid/content/Context;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_compareQQVersion_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_compareVersion_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/method[@name='compareVersion' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("compareVersion", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int CompareVersion (string p0, string p1)
		{
			if (id_compareVersion_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_compareVersion_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "compareVersion", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_compareVersion_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_extractSecureLib_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/method[@name='extractSecureLib' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("extractSecureLib", "(Ljava/lang/String;Ljava/lang/String;I)Z", "")]
		public static unsafe bool ExtractSecureLib (string p0, string p1, int p2)
		{
			if (id_extractSecureLib_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_extractSecureLib_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "extractSecureLib", "(Ljava/lang/String;Ljava/lang/String;I)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_extractSecureLib_Ljava_lang_String_Ljava_lang_String_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getActionFromRequestcode_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/method[@name='getActionFromRequestcode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getActionFromRequestcode", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetActionFromRequestcode (int p0)
		{
			if (id_getActionFromRequestcode_I == IntPtr.Zero)
				id_getActionFromRequestcode_I = JNIEnv.GetStaticMethodID (class_ref, "getActionFromRequestcode", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getActionFromRequestcode_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getAppName_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/method[@name='getAppName' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppName", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetAppName (global::Android.Content.Context p0)
		{
			if (id_getAppName_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppName_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAppName", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppName_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getAppSignatureMD5_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/method[@name='getAppSignatureMD5' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getAppSignatureMD5", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetAppSignatureMD5 (global::Android.Content.Context p0, string p1)
		{
			if (id_getAppSignatureMD5_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getAppSignatureMD5_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getAppSignatureMD5", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppSignatureMD5_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getAppVersionName_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/method[@name='getAppVersionName' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getAppVersionName", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetAppVersionName (global::Android.Content.Context p0, string p1)
		{
			if (id_getAppVersionName_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getAppVersionName_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getAppVersionName", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppVersionName_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getRealPathFromUri_Landroid_app_Activity_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/method[@name='getRealPathFromUri' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.net.Uri']]"
		[Register ("getRealPathFromUri", "(Landroid/app/Activity;Landroid/net/Uri;)Ljava/lang/String;", "")]
		public static unsafe string GetRealPathFromUri (global::Android.App.Activity p0, global::Android.Net.Uri p1)
		{
			if (id_getRealPathFromUri_Landroid_app_Activity_Landroid_net_Uri_ == IntPtr.Zero)
				id_getRealPathFromUri_Landroid_app_Activity_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "getRealPathFromUri", "(Landroid/app/Activity;Landroid/net/Uri;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRealPathFromUri_Landroid_app_Activity_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getRequestCodeFromCallback_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/method[@name='getRequestCodeFromCallback' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRequestCodeFromCallback", "(Ljava/lang/String;)I", "")]
		public static unsafe int GetRequestCodeFromCallback (string p0)
		{
			if (id_getRequestCodeFromCallback_Ljava_lang_String_ == IntPtr.Zero)
				id_getRequestCodeFromCallback_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getRequestCodeFromCallback", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getRequestCodeFromCallback_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isActivityExist_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/method[@name='isActivityExist' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("isActivityExist", "(Landroid/content/Context;Landroid/content/Intent;)Z", "")]
		public static unsafe bool IsActivityExist (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_isActivityExist_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_isActivityExist_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "isActivityExist", "(Landroid/content/Context;Landroid/content/Intent;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isActivityExist_Landroid_content_Context_Landroid_content_Intent_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isAppSignatureValid_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/method[@name='isAppSignatureValid' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("isAppSignatureValid", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool IsAppSignatureValid (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_isAppSignatureValid_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_isAppSignatureValid_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isAppSignatureValid", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAppSignatureValid_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_isLibExtracted_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='SystemUtils']/method[@name='isLibExtracted' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("isLibExtracted", "(Ljava/lang/String;I)Z", "")]
		public static unsafe bool IsLibExtracted (string p0, int p1)
		{
			if (id_isLibExtracted_Ljava_lang_String_I == IntPtr.Zero)
				id_isLibExtracted_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "isLibExtracted", "(Ljava/lang/String;I)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isLibExtracted_Ljava_lang_String_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
