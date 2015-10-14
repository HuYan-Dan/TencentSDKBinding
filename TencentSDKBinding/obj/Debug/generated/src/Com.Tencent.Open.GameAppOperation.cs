using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']"
	[global::Android.Runtime.Register ("com/tencent/open/GameAppOperation", DoNotGenerateAcw=true)]
	public partial class GameAppOperation : global::Com.Tencent.Connect.Common.BaseApi {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='GAME_FRIEND_ADD_MESSAGE']"
		[Register ("GAME_FRIEND_ADD_MESSAGE")]
		public const string GameFriendAddMessage = (string) "add_msg";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='GAME_FRIEND_LABEL']"
		[Register ("GAME_FRIEND_LABEL")]
		public const string GameFriendLabel = (string) "friend_label";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='GAME_FRIEND_OPENID']"
		[Register ("GAME_FRIEND_OPENID")]
		public const string GameFriendOpenid = (string) "fopen_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='GAME_SIGNATURE']"
		[Register ("GAME_SIGNATURE")]
		public const string GameSignature = (string) "signature";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='GAME_UNION_ID']"
		[Register ("GAME_UNION_ID")]
		public const string GameUnionId = (string) "unionid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='GAME_UNION_NAME']"
		[Register ("GAME_UNION_NAME")]
		public const string GameUnionName = (string) "union_name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='GAME_ZONE_ID']"
		[Register ("GAME_ZONE_ID")]
		public const string GameZoneId = (string) "zoneid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='PIC_SYMBOLE']"
		[Register ("PIC_SYMBOLE")]
		public const char PicSymbole = (char) (char)20;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='QQFAV_DATALINE_APPNAME']"
		[Register ("QQFAV_DATALINE_APPNAME")]
		public const string QqfavDatalineAppname = (string) "app_name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='QQFAV_DATALINE_AUDIOURL']"
		[Register ("QQFAV_DATALINE_AUDIOURL")]
		public const string QqfavDatalineAudiourl = (string) "audioUrl";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='QQFAV_DATALINE_DESCRIPTION']"
		[Register ("QQFAV_DATALINE_DESCRIPTION")]
		public const string QqfavDatalineDescription = (string) "description";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='QQFAV_DATALINE_FILEDATA']"
		[Register ("QQFAV_DATALINE_FILEDATA")]
		public const string QqfavDatalineFiledata = (string) "file_data";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='QQFAV_DATALINE_IMAGEURL']"
		[Register ("QQFAV_DATALINE_IMAGEURL")]
		public const string QqfavDatalineImageurl = (string) "image_url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='QQFAV_DATALINE_OPENID']"
		[Register ("QQFAV_DATALINE_OPENID")]
		public const string QqfavDatalineOpenid = (string) "open_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='QQFAV_DATALINE_REQTYPE']"
		[Register ("QQFAV_DATALINE_REQTYPE")]
		public const string QqfavDatalineReqtype = (string) "req_type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='QQFAV_DATALINE_SHAREID']"
		[Register ("QQFAV_DATALINE_SHAREID")]
		public const string QqfavDatalineShareid = (string) "share_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='QQFAV_DATALINE_SRCTYPE']"
		[Register ("QQFAV_DATALINE_SRCTYPE")]
		public const string QqfavDatalineSrctype = (string) "src_type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='QQFAV_DATALINE_TITLE']"
		[Register ("QQFAV_DATALINE_TITLE")]
		public const string QqfavDatalineTitle = (string) "title";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='QQFAV_DATALINE_TYPE_AUDIO']"
		[Register ("QQFAV_DATALINE_TYPE_AUDIO")]
		public const int QqfavDatalineTypeAudio = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='QQFAV_DATALINE_TYPE_DEFAULT']"
		[Register ("QQFAV_DATALINE_TYPE_DEFAULT")]
		public const int QqfavDatalineTypeDefault = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='QQFAV_DATALINE_TYPE_IMAGE_TEXT']"
		[Register ("QQFAV_DATALINE_TYPE_IMAGE_TEXT")]
		public const int QqfavDatalineTypeImageText = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='QQFAV_DATALINE_TYPE_TEXT']"
		[Register ("QQFAV_DATALINE_TYPE_TEXT")]
		public const int QqfavDatalineTypeText = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='QQFAV_DATALINE_URL']"
		[Register ("QQFAV_DATALINE_URL")]
		public const string QqfavDatalineUrl = (string) "url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='QQFAV_DATALINE_VERSION']"
		[Register ("QQFAV_DATALINE_VERSION")]
		public const string QqfavDatalineVersion = (string) "version";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='SHARE_PRIZE_ACTIVITY_ID']"
		[Register ("SHARE_PRIZE_ACTIVITY_ID")]
		public const string SharePrizeActivityId = (string) "activityid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='SHARE_PRIZE_IMAGE_URL']"
		[Register ("SHARE_PRIZE_IMAGE_URL")]
		public const string SharePrizeImageUrl = (string) "imageUrl";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='SHARE_PRIZE_SHARE_ID']"
		[Register ("SHARE_PRIZE_SHARE_ID")]
		public const string SharePrizeShareId = (string) "shareid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='SHARE_PRIZE_SHARE_ID_LIST']"
		[Register ("SHARE_PRIZE_SHARE_ID_LIST")]
		public const string SharePrizeShareIdList = (string) "shareid_list";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='SHARE_PRIZE_SUMMARY']"
		[Register ("SHARE_PRIZE_SUMMARY")]
		public const string SharePrizeSummary = (string) "summary";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='SHARE_PRIZE_SUMMARY_MAX_LENGTH']"
		[Register ("SHARE_PRIZE_SUMMARY_MAX_LENGTH")]
		public const int SharePrizeSummaryMaxLength = (int) 60;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='SHARE_PRIZE_TARGET_URL']"
		[Register ("SHARE_PRIZE_TARGET_URL")]
		public const string SharePrizeTargetUrl = (string) "targetUrl";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='SHARE_PRIZE_TITLE']"
		[Register ("SHARE_PRIZE_TITLE")]
		public const string SharePrizeTitle = (string) "title";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='SHARE_PRIZE_TITLE_MAX_LENGTH']"
		[Register ("SHARE_PRIZE_TITLE_MAX_LENGTH")]
		public const int SharePrizeTitleMaxLength = (int) 45;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/field[@name='TROOPBAR_ID']"
		[Register ("TROOPBAR_ID")]
		public const string TroopbarId = (string) "troopbar_id";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/GameAppOperation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GameAppOperation); }
		}

		protected GameAppOperation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_tencent_connect_auth_QQToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/constructor[@name='GameAppOperation' and count(parameter)=1 and parameter[1][@type='com.tencent.connect.auth.QQToken']]"
		[Register (".ctor", "(Lcom/tencent/connect/auth/QQToken;)V", "")]
		public unsafe GameAppOperation (global::Com.Tencent.Connect.Auth.QQToken p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (GameAppOperation)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/tencent/connect/auth/QQToken;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/tencent/connect/auth/QQToken;)V", __args);
					return;
				}

				if (id_ctor_Lcom_tencent_connect_auth_QQToken_ == IntPtr.Zero)
					id_ctor_Lcom_tencent_connect_auth_QQToken_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/connect/auth/QQToken;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_connect_auth_QQToken_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_connect_auth_QQToken_, __args);
			} finally {
			}
		}

		static Delegate cb_addToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetAddToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_addToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_addToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_addToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_AddToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Open.GameAppOperation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.GameAppOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AddToQQFavorites (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_addToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/method[@name='addToQQFavorites' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("addToQQFavorites", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V", "GetAddToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void AddToQQFavorites (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_addToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_addToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "addToQQFavorites", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addToQQFavorites_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addToQQFavorites", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_bindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetBindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
		{
			if (cb_bindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				cb_bindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_BindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_);
			return cb_bindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		static void n_BindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Open.GameAppOperation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.GameAppOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.BindQQGroup (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_bindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/method[@name='bindQQGroup' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("bindQQGroup", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetBindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public virtual unsafe void BindQQGroup (global::Android.App.Activity p0, global::Android.OS.Bundle p1)
		{
			if (id_bindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
				id_bindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "bindQQGroup", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_bindQQGroup_Landroid_app_Activity_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindQQGroup", "(Landroid/app/Activity;Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_exchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetExchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_exchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_exchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ExchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_exchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_ExchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Open.GameAppOperation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.GameAppOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ExchangePrize (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_exchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/method[@name='exchangePrize' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("exchangePrize", "(Landroid/content/Context;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V", "GetExchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void ExchangePrize (global::Android.Content.Context p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_exchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_exchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "exchangePrize", "(Landroid/content/Context;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_exchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "exchangePrize", "(Landroid/content/Context;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_isActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetIsActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_isActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == null)
				cb_isActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_IsActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_);
			return cb_isActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_IsActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Open.GameAppOperation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.GameAppOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.IsActivityAvailable (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_isActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/method[@name='isActivityAvailable' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("isActivityAvailable", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V", "GetIsActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void IsActivityAvailable (global::Android.App.Activity p0, string p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_isActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_isActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "isActivityAvailable", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_isActivityAvailable_Landroid_app_Activity_Ljava_lang_String_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isActivityAvailable", "(Landroid/app/Activity;Ljava/lang/String;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_makeFriend_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetMakeFriend_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
		{
			if (cb_makeFriend_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				cb_makeFriend_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_MakeFriend_Landroid_app_Activity_Landroid_os_Bundle_);
			return cb_makeFriend_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		static void n_MakeFriend_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Open.GameAppOperation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.GameAppOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.MakeFriend (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_makeFriend_Landroid_app_Activity_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/method[@name='makeFriend' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("makeFriend", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetMakeFriend_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public virtual unsafe void MakeFriend (global::Android.App.Activity p0, global::Android.OS.Bundle p1)
		{
			if (id_makeFriend_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
				id_makeFriend_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "makeFriend", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_makeFriend_Landroid_app_Activity_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "makeFriend", "(Landroid/app/Activity;Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_queryUnexchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetQueryUnexchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_queryUnexchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_queryUnexchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_QueryUnexchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_queryUnexchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_QueryUnexchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Open.GameAppOperation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.GameAppOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.QueryUnexchangePrize (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_queryUnexchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/method[@name='queryUnexchangePrize' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("queryUnexchangePrize", "(Landroid/content/Context;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V", "GetQueryUnexchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void QueryUnexchangePrize (global::Android.Content.Context p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_queryUnexchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_queryUnexchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "queryUnexchangePrize", "(Landroid/content/Context;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_queryUnexchangePrize_Landroid_content_Context_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "queryUnexchangePrize", "(Landroid/content/Context;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetSendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_sendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_sendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_sendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_SendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Open.GameAppOperation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.GameAppOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendToMyComputer (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_sendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/method[@name='sendToMyComputer' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("sendToMyComputer", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V", "GetSendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void SendToMyComputer (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_sendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_sendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "sendToMyComputer", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_sendToMyComputer_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendToMyComputer", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetSharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_sharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_sharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_sharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_SharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Open.GameAppOperation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.GameAppOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SharePrizeToQQ (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_sharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/method[@name='sharePrizeToQQ' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("sharePrizeToQQ", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V", "GetSharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void SharePrizeToQQ (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_sharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_sharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "sharePrizeToQQ", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_sharePrizeToQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sharePrizeToQQ", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_shareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetShareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_shareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_shareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ShareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_shareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_ShareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Open.GameAppOperation __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.GameAppOperation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ShareToTroopBar (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_shareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='GameAppOperation']/method[@name='shareToTroopBar' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("shareToTroopBar", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V", "GetShareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		public virtual unsafe void ShareToTroopBar (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_shareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_shareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "shareToTroopBar", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_shareToTroopBar_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shareToTroopBar", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

	}
}
