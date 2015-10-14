using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Connect.Share {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.share']/class[@name='QQShare']"
	[global::Android.Runtime.Register ("com/tencent/connect/share/QQShare", DoNotGenerateAcw=true)]
	public partial class QQShare : global::Com.Tencent.Connect.Common.BaseApi {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.share']/class[@name='QQShare']/field[@name='QQ_SHARE_SUMMARY_MAX_LENGTH']"
		[Register ("QQ_SHARE_SUMMARY_MAX_LENGTH")]
		public const int QqShareSummaryMaxLength = (int) 60;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.share']/class[@name='QQShare']/field[@name='QQ_SHARE_TITLE_MAX_LENGTH']"
		[Register ("QQ_SHARE_TITLE_MAX_LENGTH")]
		public const int QqShareTitleMaxLength = (int) 45;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.share']/class[@name='QQShare']/field[@name='SHARE_TO_QQ_APP_NAME']"
		[Register ("SHARE_TO_QQ_APP_NAME")]
		public const string ShareToQqAppName = (string) "appName";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.share']/class[@name='QQShare']/field[@name='SHARE_TO_QQ_AUDIO_URL']"
		[Register ("SHARE_TO_QQ_AUDIO_URL")]
		public const string ShareToQqAudioUrl = (string) "audio_url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.share']/class[@name='QQShare']/field[@name='SHARE_TO_QQ_EXT_INT']"
		[Register ("SHARE_TO_QQ_EXT_INT")]
		public const string ShareToQqExtInt = (string) "cflag";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.share']/class[@name='QQShare']/field[@name='SHARE_TO_QQ_EXT_STR']"
		[Register ("SHARE_TO_QQ_EXT_STR")]
		public const string ShareToQqExtStr = (string) "share_qq_ext_str";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.share']/class[@name='QQShare']/field[@name='SHARE_TO_QQ_FLAG_QZONE_AUTO_OPEN']"
		[Register ("SHARE_TO_QQ_FLAG_QZONE_AUTO_OPEN")]
		public const int ShareToQqFlagQzoneAutoOpen = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.share']/class[@name='QQShare']/field[@name='SHARE_TO_QQ_FLAG_QZONE_ITEM_HIDE']"
		[Register ("SHARE_TO_QQ_FLAG_QZONE_ITEM_HIDE")]
		public const int ShareToQqFlagQzoneItemHide = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.share']/class[@name='QQShare']/field[@name='SHARE_TO_QQ_IMAGE_LOCAL_URL']"
		[Register ("SHARE_TO_QQ_IMAGE_LOCAL_URL")]
		public const string ShareToQqImageLocalUrl = (string) "imageLocalUrl";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.share']/class[@name='QQShare']/field[@name='SHARE_TO_QQ_IMAGE_URL']"
		[Register ("SHARE_TO_QQ_IMAGE_URL")]
		public const string ShareToQqImageUrl = (string) "imageUrl";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.share']/class[@name='QQShare']/field[@name='SHARE_TO_QQ_KEY_TYPE']"
		[Register ("SHARE_TO_QQ_KEY_TYPE")]
		public const string ShareToQqKeyType = (string) "req_type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.share']/class[@name='QQShare']/field[@name='SHARE_TO_QQ_SITE']"
		[Register ("SHARE_TO_QQ_SITE")]
		public const string ShareToQqSite = (string) "site";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.share']/class[@name='QQShare']/field[@name='SHARE_TO_QQ_SUMMARY']"
		[Register ("SHARE_TO_QQ_SUMMARY")]
		public const string ShareToQqSummary = (string) "summary";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.share']/class[@name='QQShare']/field[@name='SHARE_TO_QQ_TARGET_URL']"
		[Register ("SHARE_TO_QQ_TARGET_URL")]
		public const string ShareToQqTargetUrl = (string) "targetUrl";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.share']/class[@name='QQShare']/field[@name='SHARE_TO_QQ_TITLE']"
		[Register ("SHARE_TO_QQ_TITLE")]
		public const string ShareToQqTitle = (string) "title";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.share']/class[@name='QQShare']/field[@name='SHARE_TO_QQ_TYPE_APP']"
		[Register ("SHARE_TO_QQ_TYPE_APP")]
		public const int ShareToQqTypeApp = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.share']/class[@name='QQShare']/field[@name='SHARE_TO_QQ_TYPE_AUDIO']"
		[Register ("SHARE_TO_QQ_TYPE_AUDIO")]
		public const int ShareToQqTypeAudio = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.share']/class[@name='QQShare']/field[@name='SHARE_TO_QQ_TYPE_DEFAULT']"
		[Register ("SHARE_TO_QQ_TYPE_DEFAULT")]
		public const int ShareToQqTypeDefault = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.share']/class[@name='QQShare']/field[@name='SHARE_TO_QQ_TYPE_IMAGE']"
		[Register ("SHARE_TO_QQ_TYPE_IMAGE")]
		public const int ShareToQqTypeImage = (int) 5;

		static IntPtr mViaShareQQType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.share']/class[@name='QQShare']/field[@name='mViaShareQQType']"
		[Register ("mViaShareQQType")]
		public string MViaShareQQType {
			get {
				if (mViaShareQQType_jfieldId == IntPtr.Zero)
					mViaShareQQType_jfieldId = JNIEnv.GetFieldID (class_ref, "mViaShareQQType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mViaShareQQType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mViaShareQQType_jfieldId == IntPtr.Zero)
					mViaShareQQType_jfieldId = JNIEnv.GetFieldID (class_ref, "mViaShareQQType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, mViaShareQQType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/connect/share/QQShare", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QQShare); }
		}

		protected QQShare (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect.share']/class[@name='QQShare']/constructor[@name='QQShare' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.connect.auth.QQToken']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/tencent/connect/auth/QQToken;)V", "")]
		public unsafe QQShare (global::Android.Content.Context p0, global::Com.Tencent.Connect.Auth.QQToken p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (QQShare)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lcom/tencent/connect/auth/QQToken;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lcom/tencent/connect/auth/QQToken;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/tencent/connect/auth/QQToken;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_tencent_connect_auth_QQToken_, __args);
			} finally {
			}
		}

		static Delegate cb_shareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetShareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_shareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_shareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ShareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_shareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_ShareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Connect.Share.QQShare __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Share.QQShare> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ShareToQQ (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_shareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.share']/class[@name='QQShare']/method[@name='shareToQQ' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("shareToQQ", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V", "GetShareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void ShareToQQ (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_shareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_shareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "shareToQQ", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_shareToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shareToQQ", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

	}
}
