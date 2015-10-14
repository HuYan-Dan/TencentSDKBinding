using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Connect.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']"
	[global::Android.Runtime.Register ("com/tencent/connect/common/BaseApi", DoNotGenerateAcw=true)]
	public abstract partial class BaseApi : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/field[@name='ACTION_CHECK_TOKEN']"
		[Register ("ACTION_CHECK_TOKEN")]
		protected const string ActionCheckToken = (string) "action_check_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/field[@name='ACTIVITY_AGENT']"
		[Register ("ACTIVITY_AGENT")]
		protected const string ActivityAgent = (string) "com.tencent.open.agent.AgentActivity";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/field[@name='ACTIVITY_ENCRY_TOKEN']"
		[Register ("ACTIVITY_ENCRY_TOKEN")]
		protected const string ActivityEncryToken = (string) "com.tencent.open.agent.EncryTokenActivity";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/field[@name='DEFAULT_PF']"
		[Register ("DEFAULT_PF")]
		protected const string DefaultPf = (string) "openmobile_android";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/field[@name='PARAM_ENCRY_EOKEN']"
		[Register ("PARAM_ENCRY_EOKEN")]
		protected const string ParamEncryEoken = (string) "encry_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/field[@name='PLATFORM']"
		[Register ("PLATFORM")]
		protected const string Platform = (string) "desktop_m_qq";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/field[@name='PREFERENCE_PF']"
		[Register ("PREFERENCE_PF")]
		protected const string PreferencePf = (string) "pfStore";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/field[@name='VERSION']"
		[Register ("VERSION")]
		protected const string Version = (string) "android";

		static IntPtr businessId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/field[@name='businessId']"
		[Register ("businessId")]
		public static string BusinessId {
			get {
				if (businessId_jfieldId == IntPtr.Zero)
					businessId_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "businessId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, businessId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (businessId_jfieldId == IntPtr.Zero)
					businessId_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "businessId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, businessId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr installChannel_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/field[@name='installChannel']"
		[Register ("installChannel")]
		public static string InstallChannel {
			get {
				if (installChannel_jfieldId == IntPtr.Zero)
					installChannel_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "installChannel", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, installChannel_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (installChannel_jfieldId == IntPtr.Zero)
					installChannel_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "installChannel", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, installChannel_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr isOEM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/field[@name='isOEM']"
		[Register ("isOEM")]
		public static bool IsOEM {
			get {
				if (isOEM_jfieldId == IntPtr.Zero)
					isOEM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isOEM", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, isOEM_jfieldId);
			}
			set {
				if (isOEM_jfieldId == IntPtr.Zero)
					isOEM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isOEM", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, isOEM_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mProgressDialog_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/field[@name='mProgressDialog']"
		[Register ("mProgressDialog")]
		protected global::Android.App.ProgressDialog MProgressDialog {
			get {
				if (mProgressDialog_jfieldId == IntPtr.Zero)
					mProgressDialog_jfieldId = JNIEnv.GetFieldID (class_ref, "mProgressDialog", "Landroid/app/ProgressDialog;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mProgressDialog_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.App.ProgressDialog> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mProgressDialog_jfieldId == IntPtr.Zero)
					mProgressDialog_jfieldId = JNIEnv.GetFieldID (class_ref, "mProgressDialog", "Landroid/app/ProgressDialog;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mProgressDialog_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mQQAuth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/field[@name='mQQAuth']"
		[Register ("mQQAuth")]
		protected global::Com.Tencent.Connect.Auth.QQAuth MQQAuth {
			get {
				if (mQQAuth_jfieldId == IntPtr.Zero)
					mQQAuth_jfieldId = JNIEnv.GetFieldID (class_ref, "mQQAuth", "Lcom/tencent/connect/auth/QQAuth;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mQQAuth_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQAuth> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mQQAuth_jfieldId == IntPtr.Zero)
					mQQAuth_jfieldId = JNIEnv.GetFieldID (class_ref, "mQQAuth", "Lcom/tencent/connect/auth/QQAuth;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mQQAuth_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mToken_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/field[@name='mToken']"
		[Register ("mToken")]
		protected global::Com.Tencent.Connect.Auth.QQToken MToken {
			get {
				if (mToken_jfieldId == IntPtr.Zero)
					mToken_jfieldId = JNIEnv.GetFieldID (class_ref, "mToken", "Lcom/tencent/connect/auth/QQToken;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mToken_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Auth.QQToken> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mToken_jfieldId == IntPtr.Zero)
					mToken_jfieldId = JNIEnv.GetFieldID (class_ref, "mToken", "Lcom/tencent/connect/auth/QQToken;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mToken_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr registerChannel_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/field[@name='registerChannel']"
		[Register ("registerChannel")]
		public static string RegisterChannel {
			get {
				if (registerChannel_jfieldId == IntPtr.Zero)
					registerChannel_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "registerChannel", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, registerChannel_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (registerChannel_jfieldId == IntPtr.Zero)
					registerChannel_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "registerChannel", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, registerChannel_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi.TempRequestListener']"
		[global::Android.Runtime.Register ("com/tencent/connect/common/BaseApi$TempRequestListener", DoNotGenerateAcw=true)]
		public partial class TempRequestListener : global::Java.Lang.Object, global::Com.Tencent.Tauth.IRequestListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/connect/common/BaseApi$TempRequestListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TempRequestListener); }
			}

			protected TempRequestListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_tencent_connect_common_BaseApi_Lcom_tencent_tauth_IUiListener_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi.TempRequestListener']/constructor[@name='BaseApi.TempRequestListener' and count(parameter)=2 and parameter[1][@type='com.tencent.connect.common.BaseApi'] and parameter[2][@type='com.tencent.tauth.IUiListener']]"
			[Register (".ctor", "(Lcom/tencent/connect/common/BaseApi;Lcom/tencent/tauth/IUiListener;)V", "")]
			public unsafe TempRequestListener (global::Com.Tencent.Connect.Common.BaseApi __self, global::Com.Tencent.Tauth.IUiListener p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (TempRequestListener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/tencent/tauth/IUiListener;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/tencent/tauth/IUiListener;)V", __args);
						return;
					}

					if (id_ctor_Lcom_tencent_connect_common_BaseApi_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
						id_ctor_Lcom_tencent_connect_common_BaseApi_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/connect/common/BaseApi;Lcom/tencent/tauth/IUiListener;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_connect_common_BaseApi_Lcom_tencent_tauth_IUiListener_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_connect_common_BaseApi_Lcom_tencent_tauth_IUiListener_, __args);
				} finally {
				}
			}

			static Delegate cb_onComplete_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetOnComplete_Lorg_json_JSONObject_Handler ()
			{
				if (cb_onComplete_Lorg_json_JSONObject_ == null)
					cb_onComplete_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnComplete_Lorg_json_JSONObject_);
				return cb_onComplete_Lorg_json_JSONObject_;
			}

			static void n_OnComplete_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Connect.Common.BaseApi.TempRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.BaseApi.TempRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnComplete (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onComplete_Lorg_json_JSONObject_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi.TempRequestListener']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("onComplete", "(Lorg/json/JSONObject;)V", "GetOnComplete_Lorg_json_JSONObject_Handler")]
			public virtual unsafe void OnComplete (global::Org.Json.JSONObject p0)
			{
				if (id_onComplete_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_onComplete_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Lorg/json/JSONObject;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onComplete_Lorg_json_JSONObject_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onComplete", "(Lorg/json/JSONObject;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onConnectTimeoutException_Lorg_apache_http_conn_ConnectTimeoutException_;
#pragma warning disable 0169
			static Delegate GetOnConnectTimeoutException_Lorg_apache_http_conn_ConnectTimeoutException_Handler ()
			{
				if (cb_onConnectTimeoutException_Lorg_apache_http_conn_ConnectTimeoutException_ == null)
					cb_onConnectTimeoutException_Lorg_apache_http_conn_ConnectTimeoutException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnectTimeoutException_Lorg_apache_http_conn_ConnectTimeoutException_);
				return cb_onConnectTimeoutException_Lorg_apache_http_conn_ConnectTimeoutException_;
			}

			static void n_OnConnectTimeoutException_Lorg_apache_http_conn_ConnectTimeoutException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Connect.Common.BaseApi.TempRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.BaseApi.TempRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Apache.Http.Conn.ConnectTimeoutException p0 = global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Conn.ConnectTimeoutException> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnConnectTimeoutException (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onConnectTimeoutException_Lorg_apache_http_conn_ConnectTimeoutException_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi.TempRequestListener']/method[@name='onConnectTimeoutException' and count(parameter)=1 and parameter[1][@type='org.apache.http.conn.ConnectTimeoutException']]"
			[Register ("onConnectTimeoutException", "(Lorg/apache/http/conn/ConnectTimeoutException;)V", "GetOnConnectTimeoutException_Lorg_apache_http_conn_ConnectTimeoutException_Handler")]
			public virtual unsafe void OnConnectTimeoutException (global::Org.Apache.Http.Conn.ConnectTimeoutException p0)
			{
				if (id_onConnectTimeoutException_Lorg_apache_http_conn_ConnectTimeoutException_ == IntPtr.Zero)
					id_onConnectTimeoutException_Lorg_apache_http_conn_ConnectTimeoutException_ = JNIEnv.GetMethodID (class_ref, "onConnectTimeoutException", "(Lorg/apache/http/conn/ConnectTimeoutException;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onConnectTimeoutException_Lorg_apache_http_conn_ConnectTimeoutException_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectTimeoutException", "(Lorg/apache/http/conn/ConnectTimeoutException;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onHttpStatusException_Lcom_tencent_open_utils_HttpUtils_HttpStatusException_;
#pragma warning disable 0169
			static Delegate GetOnHttpStatusException_Lcom_tencent_open_utils_HttpUtils_HttpStatusException_Handler ()
			{
				if (cb_onHttpStatusException_Lcom_tencent_open_utils_HttpUtils_HttpStatusException_ == null)
					cb_onHttpStatusException_Lcom_tencent_open_utils_HttpUtils_HttpStatusException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnHttpStatusException_Lcom_tencent_open_utils_HttpUtils_HttpStatusException_);
				return cb_onHttpStatusException_Lcom_tencent_open_utils_HttpUtils_HttpStatusException_;
			}

			static void n_OnHttpStatusException_Lcom_tencent_open_utils_HttpUtils_HttpStatusException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Connect.Common.BaseApi.TempRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.BaseApi.TempRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Open.Utils.HttpUtils.HttpStatusException p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Utils.HttpUtils.HttpStatusException> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnHttpStatusException (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onHttpStatusException_Lcom_tencent_open_utils_HttpUtils_HttpStatusException_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi.TempRequestListener']/method[@name='onHttpStatusException' and count(parameter)=1 and parameter[1][@type='com.tencent.open.utils.HttpUtils.HttpStatusException']]"
			[Register ("onHttpStatusException", "(Lcom/tencent/open/utils/HttpUtils$HttpStatusException;)V", "GetOnHttpStatusException_Lcom_tencent_open_utils_HttpUtils_HttpStatusException_Handler")]
			public virtual unsafe void OnHttpStatusException (global::Com.Tencent.Open.Utils.HttpUtils.HttpStatusException p0)
			{
				if (id_onHttpStatusException_Lcom_tencent_open_utils_HttpUtils_HttpStatusException_ == IntPtr.Zero)
					id_onHttpStatusException_Lcom_tencent_open_utils_HttpUtils_HttpStatusException_ = JNIEnv.GetMethodID (class_ref, "onHttpStatusException", "(Lcom/tencent/open/utils/HttpUtils$HttpStatusException;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onHttpStatusException_Lcom_tencent_open_utils_HttpUtils_HttpStatusException_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onHttpStatusException", "(Lcom/tencent/open/utils/HttpUtils$HttpStatusException;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onIOException_Ljava_io_IOException_;
#pragma warning disable 0169
			static Delegate GetOnIOException_Ljava_io_IOException_Handler ()
			{
				if (cb_onIOException_Ljava_io_IOException_ == null)
					cb_onIOException_Ljava_io_IOException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnIOException_Ljava_io_IOException_);
				return cb_onIOException_Ljava_io_IOException_;
			}

			static void n_OnIOException_Ljava_io_IOException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Connect.Common.BaseApi.TempRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.BaseApi.TempRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.IO.IOException p0 = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnIOException (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onIOException_Ljava_io_IOException_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi.TempRequestListener']/method[@name='onIOException' and count(parameter)=1 and parameter[1][@type='java.io.IOException']]"
			[Register ("onIOException", "(Ljava/io/IOException;)V", "GetOnIOException_Ljava_io_IOException_Handler")]
			public virtual unsafe void OnIOException (global::Java.IO.IOException p0)
			{
				if (id_onIOException_Ljava_io_IOException_ == IntPtr.Zero)
					id_onIOException_Ljava_io_IOException_ = JNIEnv.GetMethodID (class_ref, "onIOException", "(Ljava/io/IOException;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onIOException_Ljava_io_IOException_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onIOException", "(Ljava/io/IOException;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onJSONException_Lorg_json_JSONException_;
#pragma warning disable 0169
			static Delegate GetOnJSONException_Lorg_json_JSONException_Handler ()
			{
				if (cb_onJSONException_Lorg_json_JSONException_ == null)
					cb_onJSONException_Lorg_json_JSONException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnJSONException_Lorg_json_JSONException_);
				return cb_onJSONException_Lorg_json_JSONException_;
			}

			static void n_OnJSONException_Lorg_json_JSONException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Connect.Common.BaseApi.TempRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.BaseApi.TempRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONException p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONException> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnJSONException (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onJSONException_Lorg_json_JSONException_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi.TempRequestListener']/method[@name='onJSONException' and count(parameter)=1 and parameter[1][@type='org.json.JSONException']]"
			[Register ("onJSONException", "(Lorg/json/JSONException;)V", "GetOnJSONException_Lorg_json_JSONException_Handler")]
			public virtual unsafe void OnJSONException (global::Org.Json.JSONException p0)
			{
				if (id_onJSONException_Lorg_json_JSONException_ == IntPtr.Zero)
					id_onJSONException_Lorg_json_JSONException_ = JNIEnv.GetMethodID (class_ref, "onJSONException", "(Lorg/json/JSONException;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onJSONException_Lorg_json_JSONException_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onJSONException", "(Lorg/json/JSONException;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onMalformedURLException_Ljava_net_MalformedURLException_;
#pragma warning disable 0169
			static Delegate GetOnMalformedURLException_Ljava_net_MalformedURLException_Handler ()
			{
				if (cb_onMalformedURLException_Ljava_net_MalformedURLException_ == null)
					cb_onMalformedURLException_Ljava_net_MalformedURLException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMalformedURLException_Ljava_net_MalformedURLException_);
				return cb_onMalformedURLException_Ljava_net_MalformedURLException_;
			}

			static void n_OnMalformedURLException_Ljava_net_MalformedURLException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Connect.Common.BaseApi.TempRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.BaseApi.TempRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Net.MalformedURLException p0 = global::Java.Lang.Object.GetObject<global::Java.Net.MalformedURLException> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMalformedURLException (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onMalformedURLException_Ljava_net_MalformedURLException_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi.TempRequestListener']/method[@name='onMalformedURLException' and count(parameter)=1 and parameter[1][@type='java.net.MalformedURLException']]"
			[Register ("onMalformedURLException", "(Ljava/net/MalformedURLException;)V", "GetOnMalformedURLException_Ljava_net_MalformedURLException_Handler")]
			public virtual unsafe void OnMalformedURLException (global::Java.Net.MalformedURLException p0)
			{
				if (id_onMalformedURLException_Ljava_net_MalformedURLException_ == IntPtr.Zero)
					id_onMalformedURLException_Ljava_net_MalformedURLException_ = JNIEnv.GetMethodID (class_ref, "onMalformedURLException", "(Ljava/net/MalformedURLException;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onMalformedURLException_Ljava_net_MalformedURLException_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMalformedURLException", "(Ljava/net/MalformedURLException;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onNetworkUnavailableException_Lcom_tencent_open_utils_HttpUtils_NetworkUnavailableException_;
#pragma warning disable 0169
			static Delegate GetOnNetworkUnavailableException_Lcom_tencent_open_utils_HttpUtils_NetworkUnavailableException_Handler ()
			{
				if (cb_onNetworkUnavailableException_Lcom_tencent_open_utils_HttpUtils_NetworkUnavailableException_ == null)
					cb_onNetworkUnavailableException_Lcom_tencent_open_utils_HttpUtils_NetworkUnavailableException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNetworkUnavailableException_Lcom_tencent_open_utils_HttpUtils_NetworkUnavailableException_);
				return cb_onNetworkUnavailableException_Lcom_tencent_open_utils_HttpUtils_NetworkUnavailableException_;
			}

			static void n_OnNetworkUnavailableException_Lcom_tencent_open_utils_HttpUtils_NetworkUnavailableException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Connect.Common.BaseApi.TempRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.BaseApi.TempRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Open.Utils.HttpUtils.NetworkUnavailableException p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Utils.HttpUtils.NetworkUnavailableException> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnNetworkUnavailableException (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onNetworkUnavailableException_Lcom_tencent_open_utils_HttpUtils_NetworkUnavailableException_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi.TempRequestListener']/method[@name='onNetworkUnavailableException' and count(parameter)=1 and parameter[1][@type='com.tencent.open.utils.HttpUtils.NetworkUnavailableException']]"
			[Register ("onNetworkUnavailableException", "(Lcom/tencent/open/utils/HttpUtils$NetworkUnavailableException;)V", "GetOnNetworkUnavailableException_Lcom_tencent_open_utils_HttpUtils_NetworkUnavailableException_Handler")]
			public virtual unsafe void OnNetworkUnavailableException (global::Com.Tencent.Open.Utils.HttpUtils.NetworkUnavailableException p0)
			{
				if (id_onNetworkUnavailableException_Lcom_tencent_open_utils_HttpUtils_NetworkUnavailableException_ == IntPtr.Zero)
					id_onNetworkUnavailableException_Lcom_tencent_open_utils_HttpUtils_NetworkUnavailableException_ = JNIEnv.GetMethodID (class_ref, "onNetworkUnavailableException", "(Lcom/tencent/open/utils/HttpUtils$NetworkUnavailableException;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onNetworkUnavailableException_Lcom_tencent_open_utils_HttpUtils_NetworkUnavailableException_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNetworkUnavailableException", "(Lcom/tencent/open/utils/HttpUtils$NetworkUnavailableException;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onSocketTimeoutException_Ljava_net_SocketTimeoutException_;
#pragma warning disable 0169
			static Delegate GetOnSocketTimeoutException_Ljava_net_SocketTimeoutException_Handler ()
			{
				if (cb_onSocketTimeoutException_Ljava_net_SocketTimeoutException_ == null)
					cb_onSocketTimeoutException_Ljava_net_SocketTimeoutException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSocketTimeoutException_Ljava_net_SocketTimeoutException_);
				return cb_onSocketTimeoutException_Ljava_net_SocketTimeoutException_;
			}

			static void n_OnSocketTimeoutException_Ljava_net_SocketTimeoutException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Connect.Common.BaseApi.TempRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.BaseApi.TempRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Net.SocketTimeoutException p0 = global::Java.Lang.Object.GetObject<global::Java.Net.SocketTimeoutException> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSocketTimeoutException (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onSocketTimeoutException_Ljava_net_SocketTimeoutException_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi.TempRequestListener']/method[@name='onSocketTimeoutException' and count(parameter)=1 and parameter[1][@type='java.net.SocketTimeoutException']]"
			[Register ("onSocketTimeoutException", "(Ljava/net/SocketTimeoutException;)V", "GetOnSocketTimeoutException_Ljava_net_SocketTimeoutException_Handler")]
			public virtual unsafe void OnSocketTimeoutException (global::Java.Net.SocketTimeoutException p0)
			{
				if (id_onSocketTimeoutException_Ljava_net_SocketTimeoutException_ == IntPtr.Zero)
					id_onSocketTimeoutException_Ljava_net_SocketTimeoutException_ = JNIEnv.GetMethodID (class_ref, "onSocketTimeoutException", "(Ljava/net/SocketTimeoutException;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onSocketTimeoutException_Ljava_net_SocketTimeoutException_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSocketTimeoutException", "(Ljava/net/SocketTimeoutException;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onUnknowException_Ljava_lang_Exception_;
#pragma warning disable 0169
			static Delegate GetOnUnknowException_Ljava_lang_Exception_Handler ()
			{
				if (cb_onUnknowException_Ljava_lang_Exception_ == null)
					cb_onUnknowException_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUnknowException_Ljava_lang_Exception_);
				return cb_onUnknowException_Ljava_lang_Exception_;
			}

			static void n_OnUnknowException_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Connect.Common.BaseApi.TempRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.BaseApi.TempRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnUnknowException (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onUnknowException_Ljava_lang_Exception_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi.TempRequestListener']/method[@name='onUnknowException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
			[Register ("onUnknowException", "(Ljava/lang/Exception;)V", "GetOnUnknowException_Ljava_lang_Exception_Handler")]
			public virtual unsafe void OnUnknowException (global::Java.Lang.Exception p0)
			{
				if (id_onUnknowException_Ljava_lang_Exception_ == IntPtr.Zero)
					id_onUnknowException_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onUnknowException", "(Ljava/lang/Exception;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onUnknowException_Ljava_lang_Exception_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUnknowException", "(Ljava/lang/Exception;)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/connect/common/BaseApi", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseApi); }
		}

		protected BaseApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/constructor[@name='BaseApi' and count(parameter)=2 and parameter[1][@type='com.tencent.connect.auth.QQAuth'] and parameter[2][@type='com.tencent.connect.auth.QQToken']]"
		[Register (".ctor", "(Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V", "")]
		public unsafe BaseApi (global::Com.Tencent.Connect.Auth.QQAuth p0, global::Com.Tencent.Connect.Auth.QQToken p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (BaseApi)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V", __args);
					return;
				}

				if (id_ctor_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_ == IntPtr.Zero)
					id_ctor_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/connect/auth/QQAuth;Lcom/tencent/connect/auth/QQToken;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_connect_auth_QQAuth_Lcom_tencent_connect_auth_QQToken_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_tencent_connect_auth_QQToken_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/constructor[@name='BaseApi' and count(parameter)=1 and parameter[1][@type='com.tencent.connect.auth.QQToken']]"
		[Register (".ctor", "(Lcom/tencent/connect/auth/QQToken;)V", "")]
		public unsafe BaseApi (global::Com.Tencent.Connect.Auth.QQToken p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BaseApi)) {
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

		static Delegate cb_getAgentIntent;
#pragma warning disable 0169
		static Delegate GetGetAgentIntentHandler ()
		{
			if (cb_getAgentIntent == null)
				cb_getAgentIntent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAgentIntent);
			return cb_getAgentIntent;
		}

		static IntPtr n_GetAgentIntent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Connect.Common.BaseApi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.BaseApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AgentIntent);
		}
#pragma warning restore 0169

		static IntPtr id_getAgentIntent;
		protected virtual unsafe global::Android.Content.Intent AgentIntent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/method[@name='getAgentIntent' and count(parameter)=0]"
			[Register ("getAgentIntent", "()Landroid/content/Intent;", "GetGetAgentIntentHandler")]
			get {
				if (id_getAgentIntent == IntPtr.Zero)
					id_getAgentIntent = JNIEnv.GetMethodID (class_ref, "getAgentIntent", "()Landroid/content/Intent;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod  (Handle, id_getAgentIntent), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAgentIntent", "()Landroid/content/Intent;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_composeActivityParams;
#pragma warning disable 0169
		static Delegate GetComposeActivityParamsHandler ()
		{
			if (cb_composeActivityParams == null)
				cb_composeActivityParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ComposeActivityParams);
			return cb_composeActivityParams;
		}

		static IntPtr n_ComposeActivityParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Connect.Common.BaseApi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.BaseApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ComposeActivityParams ());
		}
#pragma warning restore 0169

		static IntPtr id_composeActivityParams;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/method[@name='composeActivityParams' and count(parameter)=0]"
		[Register ("composeActivityParams", "()Landroid/os/Bundle;", "GetComposeActivityParamsHandler")]
		protected virtual unsafe global::Android.OS.Bundle ComposeActivityParams ()
		{
			if (id_composeActivityParams == IntPtr.Zero)
				id_composeActivityParams = JNIEnv.GetMethodID (class_ref, "composeActivityParams", "()Landroid/os/Bundle;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_composeActivityParams), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "composeActivityParams", "()Landroid/os/Bundle;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_composeCGIParams;
#pragma warning disable 0169
		static Delegate GetComposeCGIParamsHandler ()
		{
			if (cb_composeCGIParams == null)
				cb_composeCGIParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ComposeCGIParams);
			return cb_composeCGIParams;
		}

		static IntPtr n_ComposeCGIParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Connect.Common.BaseApi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.BaseApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ComposeCGIParams ());
		}
#pragma warning restore 0169

		static IntPtr id_composeCGIParams;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/method[@name='composeCGIParams' and count(parameter)=0]"
		[Register ("composeCGIParams", "()Landroid/os/Bundle;", "GetComposeCGIParamsHandler")]
		protected virtual unsafe global::Android.OS.Bundle ComposeCGIParams ()
		{
			if (id_composeCGIParams == IntPtr.Zero)
				id_composeCGIParams = JNIEnv.GetMethodID (class_ref, "composeCGIParams", "()Landroid/os/Bundle;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_composeCGIParams), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "composeCGIParams", "()Landroid/os/Bundle;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getAgentIntentWithTarget_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAgentIntentWithTarget_Ljava_lang_String_Handler ()
		{
			if (cb_getAgentIntentWithTarget_Ljava_lang_String_ == null)
				cb_getAgentIntentWithTarget_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAgentIntentWithTarget_Ljava_lang_String_);
			return cb_getAgentIntentWithTarget_Ljava_lang_String_;
		}

		static IntPtr n_GetAgentIntentWithTarget_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Connect.Common.BaseApi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.BaseApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAgentIntentWithTarget (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAgentIntentWithTarget_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/method[@name='getAgentIntentWithTarget' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAgentIntentWithTarget", "(Ljava/lang/String;)Landroid/content/Intent;", "GetGetAgentIntentWithTarget_Ljava_lang_String_Handler")]
		protected virtual unsafe global::Android.Content.Intent GetAgentIntentWithTarget (string p0)
		{
			if (id_getAgentIntentWithTarget_Ljava_lang_String_ == IntPtr.Zero)
				id_getAgentIntentWithTarget_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAgentIntentWithTarget", "(Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Android.Content.Intent __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod  (Handle, id_getAgentIntentWithTarget_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAgentIntentWithTarget", "(Ljava/lang/String;)Landroid/content/Intent;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getCommonDownloadQQUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCommonDownloadQQUrl_Ljava_lang_String_Handler ()
		{
			if (cb_getCommonDownloadQQUrl_Ljava_lang_String_ == null)
				cb_getCommonDownloadQQUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCommonDownloadQQUrl_Ljava_lang_String_);
			return cb_getCommonDownloadQQUrl_Ljava_lang_String_;
		}

		static IntPtr n_GetCommonDownloadQQUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Connect.Common.BaseApi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.BaseApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetCommonDownloadQQUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getCommonDownloadQQUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/method[@name='getCommonDownloadQQUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCommonDownloadQQUrl", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetCommonDownloadQQUrl_Ljava_lang_String_Handler")]
		protected virtual unsafe string GetCommonDownloadQQUrl (string p0)
		{
			if (id_getCommonDownloadQQUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_getCommonDownloadQQUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCommonDownloadQQUrl", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCommonDownloadQQUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCommonDownloadQQUrl", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getTargetActivityIntent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTargetActivityIntent_Ljava_lang_String_Handler ()
		{
			if (cb_getTargetActivityIntent_Ljava_lang_String_ == null)
				cb_getTargetActivityIntent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTargetActivityIntent_Ljava_lang_String_);
			return cb_getTargetActivityIntent_Ljava_lang_String_;
		}

		static IntPtr n_GetTargetActivityIntent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Connect.Common.BaseApi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.BaseApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTargetActivityIntent (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTargetActivityIntent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/method[@name='getTargetActivityIntent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTargetActivityIntent", "(Ljava/lang/String;)Landroid/content/Intent;", "GetGetTargetActivityIntent_Ljava_lang_String_Handler")]
		protected virtual unsafe global::Android.Content.Intent GetTargetActivityIntent (string p0)
		{
			if (id_getTargetActivityIntent_Ljava_lang_String_ == IntPtr.Zero)
				id_getTargetActivityIntent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getTargetActivityIntent", "(Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Android.Content.Intent __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod  (Handle, id_getTargetActivityIntent_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTargetActivityIntent", "(Ljava/lang/String;)Landroid/content/Intent;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_handleDownloadLastestQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
#pragma warning disable 0169
		static Delegate GetHandleDownloadLastestQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler ()
		{
			if (cb_handleDownloadLastestQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == null)
				cb_handleDownloadLastestQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_HandleDownloadLastestQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_);
			return cb_handleDownloadLastestQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		}

		static void n_HandleDownloadLastestQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Connect.Common.BaseApi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.BaseApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tauth.IUiListener p2 = (global::Com.Tencent.Tauth.IUiListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IUiListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.HandleDownloadLastestQQ (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_handleDownloadLastestQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/method[@name='handleDownloadLastestQQ' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.tencent.tauth.IUiListener']]"
		[Register ("handleDownloadLastestQQ", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V", "GetHandleDownloadLastestQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_Handler")]
		protected virtual unsafe void HandleDownloadLastestQQ (global::Android.App.Activity p0, global::Android.OS.Bundle p1, global::Com.Tencent.Tauth.IUiListener p2)
		{
			if (id_handleDownloadLastestQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ == IntPtr.Zero)
				id_handleDownloadLastestQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_ = JNIEnv.GetMethodID (class_ref, "handleDownloadLastestQQ", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_handleDownloadLastestQQ_Landroid_app_Activity_Landroid_os_Bundle_Lcom_tencent_tauth_IUiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleDownloadLastestQQ", "(Landroid/app/Activity;Landroid/os/Bundle;Lcom/tencent/tauth/IUiListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_hasActivityForIntent_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetHasActivityForIntent_Landroid_content_Intent_Handler ()
		{
			if (cb_hasActivityForIntent_Landroid_content_Intent_ == null)
				cb_hasActivityForIntent_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HasActivityForIntent_Landroid_content_Intent_);
			return cb_hasActivityForIntent_Landroid_content_Intent_;
		}

		static bool n_HasActivityForIntent_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Connect.Common.BaseApi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.BaseApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasActivityForIntent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_hasActivityForIntent_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/method[@name='hasActivityForIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("hasActivityForIntent", "(Landroid/content/Intent;)Z", "GetHasActivityForIntent_Landroid_content_Intent_Handler")]
		protected virtual unsafe bool HasActivityForIntent (global::Android.Content.Intent p0)
		{
			if (id_hasActivityForIntent_Landroid_content_Intent_ == IntPtr.Zero)
				id_hasActivityForIntent_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "hasActivityForIntent", "(Landroid/content/Intent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_hasActivityForIntent_Landroid_content_Intent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasActivityForIntent", "(Landroid/content/Intent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_releaseResource;
#pragma warning disable 0169
		static Delegate GetReleaseResourceHandler ()
		{
			if (cb_releaseResource == null)
				cb_releaseResource = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReleaseResource);
			return cb_releaseResource;
		}

		static void n_ReleaseResource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Connect.Common.BaseApi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.BaseApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseResource ();
		}
#pragma warning restore 0169

		static IntPtr id_releaseResource;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/method[@name='releaseResource' and count(parameter)=0]"
		[Register ("releaseResource", "()V", "GetReleaseResourceHandler")]
		public virtual unsafe void ReleaseResource ()
		{
			if (id_releaseResource == IntPtr.Zero)
				id_releaseResource = JNIEnv.GetMethodID (class_ref, "releaseResource", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_releaseResource);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "releaseResource", "()V"));
			} finally {
			}
		}

		static Delegate cb_showProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShowProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_showProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_showProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_);
			return cb_showProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_ShowProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Connect.Common.BaseApi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.BaseApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ShowProgressDialog (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_showProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/method[@name='showProgressDialog' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("showProgressDialog", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "GetShowProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe void ShowProgressDialog (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_showProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_showProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "showProgressDialog", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_showProgressDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showProgressDialog", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_startAssistActivity_Landroid_app_Activity_Landroid_os_Bundle_ILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetStartAssistActivity_Landroid_app_Activity_Landroid_os_Bundle_ILandroid_content_Intent_Handler ()
		{
			if (cb_startAssistActivity_Landroid_app_Activity_Landroid_os_Bundle_ILandroid_content_Intent_ == null)
				cb_startAssistActivity_Landroid_app_Activity_Landroid_os_Bundle_ILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_StartAssistActivity_Landroid_app_Activity_Landroid_os_Bundle_ILandroid_content_Intent_);
			return cb_startAssistActivity_Landroid_app_Activity_Landroid_os_Bundle_ILandroid_content_Intent_;
		}

		static void n_StartAssistActivity_Landroid_app_Activity_Landroid_os_Bundle_ILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3)
		{
			global::Com.Tencent.Connect.Common.BaseApi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.BaseApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p3 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.StartAssistActivity (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_startAssistActivity_Landroid_app_Activity_Landroid_os_Bundle_ILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/method[@name='startAssistActivity' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='int'] and parameter[4][@type='android.content.Intent']]"
		[Register ("startAssistActivity", "(Landroid/app/Activity;Landroid/os/Bundle;ILandroid/content/Intent;)V", "GetStartAssistActivity_Landroid_app_Activity_Landroid_os_Bundle_ILandroid_content_Intent_Handler")]
		protected virtual unsafe void StartAssistActivity (global::Android.App.Activity p0, global::Android.OS.Bundle p1, int p2, global::Android.Content.Intent p3)
		{
			if (id_startAssistActivity_Landroid_app_Activity_Landroid_os_Bundle_ILandroid_content_Intent_ == IntPtr.Zero)
				id_startAssistActivity_Landroid_app_Activity_Landroid_os_Bundle_ILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "startAssistActivity", "(Landroid/app/Activity;Landroid/os/Bundle;ILandroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startAssistActivity_Landroid_app_Activity_Landroid_os_Bundle_ILandroid_content_Intent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startAssistActivity", "(Landroid/app/Activity;Landroid/os/Bundle;ILandroid/content/Intent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startAssistActivity_Landroid_app_Activity_ILandroid_content_Intent_Z;
#pragma warning disable 0169
		static Delegate GetStartAssistActivity_Landroid_app_Activity_ILandroid_content_Intent_ZHandler ()
		{
			if (cb_startAssistActivity_Landroid_app_Activity_ILandroid_content_Intent_Z == null)
				cb_startAssistActivity_Landroid_app_Activity_ILandroid_content_Intent_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_StartAssistActivity_Landroid_app_Activity_ILandroid_content_Intent_Z);
			return cb_startAssistActivity_Landroid_app_Activity_ILandroid_content_Intent_Z;
		}

		static void n_StartAssistActivity_Landroid_app_Activity_ILandroid_content_Intent_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, bool p3)
		{
			global::Com.Tencent.Connect.Common.BaseApi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.BaseApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.StartAssistActivity (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_startAssistActivity_Landroid_app_Activity_ILandroid_content_Intent_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/method[@name='startAssistActivity' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent'] and parameter[4][@type='boolean']]"
		[Register ("startAssistActivity", "(Landroid/app/Activity;ILandroid/content/Intent;Z)V", "GetStartAssistActivity_Landroid_app_Activity_ILandroid_content_Intent_ZHandler")]
		protected virtual unsafe void StartAssistActivity (global::Android.App.Activity p0, int p1, global::Android.Content.Intent p2, bool p3)
		{
			if (id_startAssistActivity_Landroid_app_Activity_ILandroid_content_Intent_Z == IntPtr.Zero)
				id_startAssistActivity_Landroid_app_Activity_ILandroid_content_Intent_Z = JNIEnv.GetMethodID (class_ref, "startAssistActivity", "(Landroid/app/Activity;ILandroid/content/Intent;Z)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startAssistActivity_Landroid_app_Activity_ILandroid_content_Intent_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startAssistActivity", "(Landroid/app/Activity;ILandroid/content/Intent;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startAssitActivity_Landroid_app_Activity_Landroid_content_Intent_I;
#pragma warning disable 0169
		static Delegate GetStartAssitActivity_Landroid_app_Activity_Landroid_content_Intent_IHandler ()
		{
			if (cb_startAssitActivity_Landroid_app_Activity_Landroid_content_Intent_I == null)
				cb_startAssitActivity_Landroid_app_Activity_Landroid_content_Intent_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_StartAssitActivity_Landroid_app_Activity_Landroid_content_Intent_I);
			return cb_startAssitActivity_Landroid_app_Activity_Landroid_content_Intent_I;
		}

		static void n_StartAssitActivity_Landroid_app_Activity_Landroid_content_Intent_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Tencent.Connect.Common.BaseApi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.BaseApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartAssitActivity (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_startAssitActivity_Landroid_app_Activity_Landroid_content_Intent_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/method[@name='startAssitActivity' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='int']]"
		[Register ("startAssitActivity", "(Landroid/app/Activity;Landroid/content/Intent;I)V", "GetStartAssitActivity_Landroid_app_Activity_Landroid_content_Intent_IHandler")]
		protected virtual unsafe void StartAssitActivity (global::Android.App.Activity p0, global::Android.Content.Intent p1, int p2)
		{
			if (id_startAssitActivity_Landroid_app_Activity_Landroid_content_Intent_I == IntPtr.Zero)
				id_startAssitActivity_Landroid_app_Activity_Landroid_content_Intent_I = JNIEnv.GetMethodID (class_ref, "startAssitActivity", "(Landroid/app/Activity;Landroid/content/Intent;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startAssitActivity_Landroid_app_Activity_Landroid_content_Intent_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startAssitActivity", "(Landroid/app/Activity;Landroid/content/Intent;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startAssitActivity_Landroid_support_v4_app_Fragment_Landroid_content_Intent_I;
#pragma warning disable 0169
		static Delegate GetStartAssitActivity_Landroid_support_v4_app_Fragment_Landroid_content_Intent_IHandler ()
		{
			if (cb_startAssitActivity_Landroid_support_v4_app_Fragment_Landroid_content_Intent_I == null)
				cb_startAssitActivity_Landroid_support_v4_app_Fragment_Landroid_content_Intent_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_StartAssitActivity_Landroid_support_v4_app_Fragment_Landroid_content_Intent_I);
			return cb_startAssitActivity_Landroid_support_v4_app_Fragment_Landroid_content_Intent_I;
		}

		static void n_StartAssitActivity_Landroid_support_v4_app_Fragment_Landroid_content_Intent_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Tencent.Connect.Common.BaseApi __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Connect.Common.BaseApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.Fragment p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartAssitActivity (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_startAssitActivity_Landroid_support_v4_app_Fragment_Landroid_content_Intent_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.connect.common']/class[@name='BaseApi']/method[@name='startAssitActivity' and count(parameter)=3 and parameter[1][@type='android.support.v4.app.Fragment'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='int']]"
		[Register ("startAssitActivity", "(Landroid/support/v4/app/Fragment;Landroid/content/Intent;I)V", "GetStartAssitActivity_Landroid_support_v4_app_Fragment_Landroid_content_Intent_IHandler")]
		protected virtual unsafe void StartAssitActivity (global::Android.Support.V4.App.Fragment p0, global::Android.Content.Intent p1, int p2)
		{
			if (id_startAssitActivity_Landroid_support_v4_app_Fragment_Landroid_content_Intent_I == IntPtr.Zero)
				id_startAssitActivity_Landroid_support_v4_app_Fragment_Landroid_content_Intent_I = JNIEnv.GetMethodID (class_ref, "startAssitActivity", "(Landroid/support/v4/app/Fragment;Landroid/content/Intent;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startAssitActivity_Landroid_support_v4_app_Fragment_Landroid_content_Intent_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startAssitActivity", "(Landroid/support/v4/app/Fragment;Landroid/content/Intent;I)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/tencent/connect/common/BaseApi", DoNotGenerateAcw=true)]
	internal partial class BaseApiInvoker : BaseApi {

		public BaseApiInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseApiInvoker); }
		}

	}

}
