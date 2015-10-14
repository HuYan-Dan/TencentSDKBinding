using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Tauth {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.tauth']/interface[@name='IRequestListener']"
	[Register ("com/tencent/tauth/IRequestListener", "", "Com.Tencent.Tauth.IRequestListenerInvoker")]
	public partial interface IRequestListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/interface[@name='IRequestListener']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("onComplete", "(Lorg/json/JSONObject;)V", "GetOnComplete_Lorg_json_JSONObject_Handler:Com.Tencent.Tauth.IRequestListenerInvoker, TencentSDKBinding_v2.9.3")]
		void OnComplete (global::Org.Json.JSONObject p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/interface[@name='IRequestListener']/method[@name='onConnectTimeoutException' and count(parameter)=1 and parameter[1][@type='org.apache.http.conn.ConnectTimeoutException']]"
		[Register ("onConnectTimeoutException", "(Lorg/apache/http/conn/ConnectTimeoutException;)V", "GetOnConnectTimeoutException_Lorg_apache_http_conn_ConnectTimeoutException_Handler:Com.Tencent.Tauth.IRequestListenerInvoker, TencentSDKBinding_v2.9.3")]
		void OnConnectTimeoutException (global::Org.Apache.Http.Conn.ConnectTimeoutException p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/interface[@name='IRequestListener']/method[@name='onHttpStatusException' and count(parameter)=1 and parameter[1][@type='com.tencent.open.utils.HttpUtils.HttpStatusException']]"
		[Register ("onHttpStatusException", "(Lcom/tencent/open/utils/HttpUtils$HttpStatusException;)V", "GetOnHttpStatusException_Lcom_tencent_open_utils_HttpUtils_HttpStatusException_Handler:Com.Tencent.Tauth.IRequestListenerInvoker, TencentSDKBinding_v2.9.3")]
		void OnHttpStatusException (global::Com.Tencent.Open.Utils.HttpUtils.HttpStatusException p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/interface[@name='IRequestListener']/method[@name='onIOException' and count(parameter)=1 and parameter[1][@type='java.io.IOException']]"
		[Register ("onIOException", "(Ljava/io/IOException;)V", "GetOnIOException_Ljava_io_IOException_Handler:Com.Tencent.Tauth.IRequestListenerInvoker, TencentSDKBinding_v2.9.3")]
		void OnIOException (global::Java.IO.IOException p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/interface[@name='IRequestListener']/method[@name='onJSONException' and count(parameter)=1 and parameter[1][@type='org.json.JSONException']]"
		[Register ("onJSONException", "(Lorg/json/JSONException;)V", "GetOnJSONException_Lorg_json_JSONException_Handler:Com.Tencent.Tauth.IRequestListenerInvoker, TencentSDKBinding_v2.9.3")]
		void OnJSONException (global::Org.Json.JSONException p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/interface[@name='IRequestListener']/method[@name='onMalformedURLException' and count(parameter)=1 and parameter[1][@type='java.net.MalformedURLException']]"
		[Register ("onMalformedURLException", "(Ljava/net/MalformedURLException;)V", "GetOnMalformedURLException_Ljava_net_MalformedURLException_Handler:Com.Tencent.Tauth.IRequestListenerInvoker, TencentSDKBinding_v2.9.3")]
		void OnMalformedURLException (global::Java.Net.MalformedURLException p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/interface[@name='IRequestListener']/method[@name='onNetworkUnavailableException' and count(parameter)=1 and parameter[1][@type='com.tencent.open.utils.HttpUtils.NetworkUnavailableException']]"
		[Register ("onNetworkUnavailableException", "(Lcom/tencent/open/utils/HttpUtils$NetworkUnavailableException;)V", "GetOnNetworkUnavailableException_Lcom_tencent_open_utils_HttpUtils_NetworkUnavailableException_Handler:Com.Tencent.Tauth.IRequestListenerInvoker, TencentSDKBinding_v2.9.3")]
		void OnNetworkUnavailableException (global::Com.Tencent.Open.Utils.HttpUtils.NetworkUnavailableException p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/interface[@name='IRequestListener']/method[@name='onSocketTimeoutException' and count(parameter)=1 and parameter[1][@type='java.net.SocketTimeoutException']]"
		[Register ("onSocketTimeoutException", "(Ljava/net/SocketTimeoutException;)V", "GetOnSocketTimeoutException_Ljava_net_SocketTimeoutException_Handler:Com.Tencent.Tauth.IRequestListenerInvoker, TencentSDKBinding_v2.9.3")]
		void OnSocketTimeoutException (global::Java.Net.SocketTimeoutException p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tauth']/interface[@name='IRequestListener']/method[@name='onUnknowException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onUnknowException", "(Ljava/lang/Exception;)V", "GetOnUnknowException_Ljava_lang_Exception_Handler:Com.Tencent.Tauth.IRequestListenerInvoker, TencentSDKBinding_v2.9.3")]
		void OnUnknowException (global::Java.Lang.Exception p0);

	}

	[global::Android.Runtime.Register ("com/tencent/tauth/IRequestListener", DoNotGenerateAcw=true)]
	internal class IRequestListenerInvoker : global::Java.Lang.Object, IRequestListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/tauth/IRequestListener");
		IntPtr class_ref;

		public static IRequestListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRequestListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.tencent.tauth.IRequestListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRequestListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IRequestListenerInvoker); }
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
			global::Com.Tencent.Tauth.IRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete (p0);
		}
#pragma warning restore 0169

		IntPtr id_onComplete_Lorg_json_JSONObject_;
		public unsafe void OnComplete (global::Org.Json.JSONObject p0)
		{
			if (id_onComplete_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_onComplete_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Lorg/json/JSONObject;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onComplete_Lorg_json_JSONObject_, __args);
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
			global::Com.Tencent.Tauth.IRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Apache.Http.Conn.ConnectTimeoutException p0 = global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Conn.ConnectTimeoutException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectTimeoutException (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConnectTimeoutException_Lorg_apache_http_conn_ConnectTimeoutException_;
		public unsafe void OnConnectTimeoutException (global::Org.Apache.Http.Conn.ConnectTimeoutException p0)
		{
			if (id_onConnectTimeoutException_Lorg_apache_http_conn_ConnectTimeoutException_ == IntPtr.Zero)
				id_onConnectTimeoutException_Lorg_apache_http_conn_ConnectTimeoutException_ = JNIEnv.GetMethodID (class_ref, "onConnectTimeoutException", "(Lorg/apache/http/conn/ConnectTimeoutException;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onConnectTimeoutException_Lorg_apache_http_conn_ConnectTimeoutException_, __args);
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
			global::Com.Tencent.Tauth.IRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Open.Utils.HttpUtils.HttpStatusException p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Utils.HttpUtils.HttpStatusException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnHttpStatusException (p0);
		}
#pragma warning restore 0169

		IntPtr id_onHttpStatusException_Lcom_tencent_open_utils_HttpUtils_HttpStatusException_;
		public unsafe void OnHttpStatusException (global::Com.Tencent.Open.Utils.HttpUtils.HttpStatusException p0)
		{
			if (id_onHttpStatusException_Lcom_tencent_open_utils_HttpUtils_HttpStatusException_ == IntPtr.Zero)
				id_onHttpStatusException_Lcom_tencent_open_utils_HttpUtils_HttpStatusException_ = JNIEnv.GetMethodID (class_ref, "onHttpStatusException", "(Lcom/tencent/open/utils/HttpUtils$HttpStatusException;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onHttpStatusException_Lcom_tencent_open_utils_HttpUtils_HttpStatusException_, __args);
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
			global::Com.Tencent.Tauth.IRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.IOException p0 = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnIOException (p0);
		}
#pragma warning restore 0169

		IntPtr id_onIOException_Ljava_io_IOException_;
		public unsafe void OnIOException (global::Java.IO.IOException p0)
		{
			if (id_onIOException_Ljava_io_IOException_ == IntPtr.Zero)
				id_onIOException_Ljava_io_IOException_ = JNIEnv.GetMethodID (class_ref, "onIOException", "(Ljava/io/IOException;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onIOException_Ljava_io_IOException_, __args);
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
			global::Com.Tencent.Tauth.IRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONException p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnJSONException (p0);
		}
#pragma warning restore 0169

		IntPtr id_onJSONException_Lorg_json_JSONException_;
		public unsafe void OnJSONException (global::Org.Json.JSONException p0)
		{
			if (id_onJSONException_Lorg_json_JSONException_ == IntPtr.Zero)
				id_onJSONException_Lorg_json_JSONException_ = JNIEnv.GetMethodID (class_ref, "onJSONException", "(Lorg/json/JSONException;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onJSONException_Lorg_json_JSONException_, __args);
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
			global::Com.Tencent.Tauth.IRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.MalformedURLException p0 = global::Java.Lang.Object.GetObject<global::Java.Net.MalformedURLException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMalformedURLException (p0);
		}
#pragma warning restore 0169

		IntPtr id_onMalformedURLException_Ljava_net_MalformedURLException_;
		public unsafe void OnMalformedURLException (global::Java.Net.MalformedURLException p0)
		{
			if (id_onMalformedURLException_Ljava_net_MalformedURLException_ == IntPtr.Zero)
				id_onMalformedURLException_Ljava_net_MalformedURLException_ = JNIEnv.GetMethodID (class_ref, "onMalformedURLException", "(Ljava/net/MalformedURLException;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onMalformedURLException_Ljava_net_MalformedURLException_, __args);
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
			global::Com.Tencent.Tauth.IRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Open.Utils.HttpUtils.NetworkUnavailableException p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Utils.HttpUtils.NetworkUnavailableException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNetworkUnavailableException (p0);
		}
#pragma warning restore 0169

		IntPtr id_onNetworkUnavailableException_Lcom_tencent_open_utils_HttpUtils_NetworkUnavailableException_;
		public unsafe void OnNetworkUnavailableException (global::Com.Tencent.Open.Utils.HttpUtils.NetworkUnavailableException p0)
		{
			if (id_onNetworkUnavailableException_Lcom_tencent_open_utils_HttpUtils_NetworkUnavailableException_ == IntPtr.Zero)
				id_onNetworkUnavailableException_Lcom_tencent_open_utils_HttpUtils_NetworkUnavailableException_ = JNIEnv.GetMethodID (class_ref, "onNetworkUnavailableException", "(Lcom/tencent/open/utils/HttpUtils$NetworkUnavailableException;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onNetworkUnavailableException_Lcom_tencent_open_utils_HttpUtils_NetworkUnavailableException_, __args);
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
			global::Com.Tencent.Tauth.IRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.SocketTimeoutException p0 = global::Java.Lang.Object.GetObject<global::Java.Net.SocketTimeoutException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSocketTimeoutException (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSocketTimeoutException_Ljava_net_SocketTimeoutException_;
		public unsafe void OnSocketTimeoutException (global::Java.Net.SocketTimeoutException p0)
		{
			if (id_onSocketTimeoutException_Ljava_net_SocketTimeoutException_ == IntPtr.Zero)
				id_onSocketTimeoutException_Ljava_net_SocketTimeoutException_ = JNIEnv.GetMethodID (class_ref, "onSocketTimeoutException", "(Ljava/net/SocketTimeoutException;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onSocketTimeoutException_Ljava_net_SocketTimeoutException_, __args);
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
			global::Com.Tencent.Tauth.IRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tauth.IRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUnknowException (p0);
		}
#pragma warning restore 0169

		IntPtr id_onUnknowException_Ljava_lang_Exception_;
		public unsafe void OnUnknowException (global::Java.Lang.Exception p0)
		{
			if (id_onUnknowException_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onUnknowException_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onUnknowException", "(Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onUnknowException_Ljava_lang_Exception_, __args);
		}

	}

	public partial class CompleteEventArgs : global::System.EventArgs {

		public CompleteEventArgs (global::Org.Json.JSONObject p0)
		{
			this.p0 = p0;
		}

		global::Org.Json.JSONObject p0;
		public global::Org.Json.JSONObject P0 {
			get { return p0; }
		}
	}

	public partial class ConnectTimeoutExceptionEventArgs : global::System.EventArgs {

		public ConnectTimeoutExceptionEventArgs (global::Org.Apache.Http.Conn.ConnectTimeoutException p0)
		{
			this.p0 = p0;
		}

		global::Org.Apache.Http.Conn.ConnectTimeoutException p0;
		public global::Org.Apache.Http.Conn.ConnectTimeoutException P0 {
			get { return p0; }
		}
	}

	public partial class HttpStatusExceptionEventArgs : global::System.EventArgs {

		public HttpStatusExceptionEventArgs (global::Com.Tencent.Open.Utils.HttpUtils.HttpStatusException p0)
		{
			this.p0 = p0;
		}

		global::Com.Tencent.Open.Utils.HttpUtils.HttpStatusException p0;
		public global::Com.Tencent.Open.Utils.HttpUtils.HttpStatusException P0 {
			get { return p0; }
		}
	}

	public partial class IOExceptionEventArgs : global::System.EventArgs {

		public IOExceptionEventArgs (global::Java.IO.IOException p0)
		{
			this.p0 = p0;
		}

		global::Java.IO.IOException p0;
		public global::Java.IO.IOException P0 {
			get { return p0; }
		}
	}

	public partial class JSONExceptionEventArgs : global::System.EventArgs {

		public JSONExceptionEventArgs (global::Org.Json.JSONException p0)
		{
			this.p0 = p0;
		}

		global::Org.Json.JSONException p0;
		public global::Org.Json.JSONException P0 {
			get { return p0; }
		}
	}

	public partial class MalformedURLExceptionEventArgs : global::System.EventArgs {

		public MalformedURLExceptionEventArgs (global::Java.Net.MalformedURLException p0)
		{
			this.p0 = p0;
		}

		global::Java.Net.MalformedURLException p0;
		public global::Java.Net.MalformedURLException P0 {
			get { return p0; }
		}
	}

	public partial class NetworkUnavailableExceptionEventArgs : global::System.EventArgs {

		public NetworkUnavailableExceptionEventArgs (global::Com.Tencent.Open.Utils.HttpUtils.NetworkUnavailableException p0)
		{
			this.p0 = p0;
		}

		global::Com.Tencent.Open.Utils.HttpUtils.NetworkUnavailableException p0;
		public global::Com.Tencent.Open.Utils.HttpUtils.NetworkUnavailableException P0 {
			get { return p0; }
		}
	}

	public partial class SocketTimeoutExceptionEventArgs : global::System.EventArgs {

		public SocketTimeoutExceptionEventArgs (global::Java.Net.SocketTimeoutException p0)
		{
			this.p0 = p0;
		}

		global::Java.Net.SocketTimeoutException p0;
		public global::Java.Net.SocketTimeoutException P0 {
			get { return p0; }
		}
	}

	public partial class UnknowExceptionEventArgs : global::System.EventArgs {

		public UnknowExceptionEventArgs (global::Java.Lang.Exception p0)
		{
			this.p0 = p0;
		}

		global::Java.Lang.Exception p0;
		public global::Java.Lang.Exception P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/tencent/tauth/IRequestListenerImplementor")]
	internal sealed partial class IRequestListenerImplementor : global::Java.Lang.Object, IRequestListener {

		object sender;

		public IRequestListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/tencent/tauth/IRequestListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CompleteEventArgs> OnCompleteHandler;
#pragma warning restore 0649

		public void OnComplete (global::Org.Json.JSONObject p0)
		{
			var __h = OnCompleteHandler;
			if (__h != null)
				__h (sender, new CompleteEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<ConnectTimeoutExceptionEventArgs> OnConnectTimeoutExceptionHandler;
#pragma warning restore 0649

		public void OnConnectTimeoutException (global::Org.Apache.Http.Conn.ConnectTimeoutException p0)
		{
			var __h = OnConnectTimeoutExceptionHandler;
			if (__h != null)
				__h (sender, new ConnectTimeoutExceptionEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<HttpStatusExceptionEventArgs> OnHttpStatusExceptionHandler;
#pragma warning restore 0649

		public void OnHttpStatusException (global::Com.Tencent.Open.Utils.HttpUtils.HttpStatusException p0)
		{
			var __h = OnHttpStatusExceptionHandler;
			if (__h != null)
				__h (sender, new HttpStatusExceptionEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<IOExceptionEventArgs> OnIOExceptionHandler;
#pragma warning restore 0649

		public void OnIOException (global::Java.IO.IOException p0)
		{
			var __h = OnIOExceptionHandler;
			if (__h != null)
				__h (sender, new IOExceptionEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<JSONExceptionEventArgs> OnJSONExceptionHandler;
#pragma warning restore 0649

		public void OnJSONException (global::Org.Json.JSONException p0)
		{
			var __h = OnJSONExceptionHandler;
			if (__h != null)
				__h (sender, new JSONExceptionEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<MalformedURLExceptionEventArgs> OnMalformedURLExceptionHandler;
#pragma warning restore 0649

		public void OnMalformedURLException (global::Java.Net.MalformedURLException p0)
		{
			var __h = OnMalformedURLExceptionHandler;
			if (__h != null)
				__h (sender, new MalformedURLExceptionEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<NetworkUnavailableExceptionEventArgs> OnNetworkUnavailableExceptionHandler;
#pragma warning restore 0649

		public void OnNetworkUnavailableException (global::Com.Tencent.Open.Utils.HttpUtils.NetworkUnavailableException p0)
		{
			var __h = OnNetworkUnavailableExceptionHandler;
			if (__h != null)
				__h (sender, new NetworkUnavailableExceptionEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<SocketTimeoutExceptionEventArgs> OnSocketTimeoutExceptionHandler;
#pragma warning restore 0649

		public void OnSocketTimeoutException (global::Java.Net.SocketTimeoutException p0)
		{
			var __h = OnSocketTimeoutExceptionHandler;
			if (__h != null)
				__h (sender, new SocketTimeoutExceptionEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<UnknowExceptionEventArgs> OnUnknowExceptionHandler;
#pragma warning restore 0649

		public void OnUnknowException (global::Java.Lang.Exception p0)
		{
			var __h = OnUnknowExceptionHandler;
			if (__h != null)
				__h (sender, new UnknowExceptionEventArgs (p0));
		}

		internal static bool __IsEmpty (IRequestListenerImplementor value)
		{
			return value.OnCompleteHandler == null && value.OnConnectTimeoutExceptionHandler == null && value.OnHttpStatusExceptionHandler == null && value.OnIOExceptionHandler == null && value.OnJSONExceptionHandler == null && value.OnMalformedURLExceptionHandler == null && value.OnNetworkUnavailableExceptionHandler == null && value.OnSocketTimeoutExceptionHandler == null && value.OnUnknowExceptionHandler == null;
		}
	}

}
