using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils']"
	[global::Android.Runtime.Register ("com/tencent/open/utils/HttpUtils", DoNotGenerateAcw=true)]
	public partial class HttpUtils : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils.CustomSSLSocketFactory']"
		[global::Android.Runtime.Register ("com/tencent/open/utils/HttpUtils$CustomSSLSocketFactory", DoNotGenerateAcw=true)]
		public partial class CustomSSLSocketFactory : global::Org.Apache.Http.Conn.Ssl.SSLSocketFactory {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/open/utils/HttpUtils$CustomSSLSocketFactory", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CustomSSLSocketFactory); }
			}

			protected CustomSSLSocketFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_security_KeyStore_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils.CustomSSLSocketFactory']/constructor[@name='HttpUtils.CustomSSLSocketFactory' and count(parameter)=1 and parameter[1][@type='java.security.KeyStore']]"
			[Register (".ctor", "(Ljava/security/KeyStore;)V", "")]
			public unsafe CustomSSLSocketFactory (global::Java.Security.KeyStore p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (CustomSSLSocketFactory)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/security/KeyStore;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/security/KeyStore;)V", __args);
						return;
					}

					if (id_ctor_Ljava_security_KeyStore_ == IntPtr.Zero)
						id_ctor_Ljava_security_KeyStore_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/security/KeyStore;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_security_KeyStore_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_security_KeyStore_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils.HttpStatusException']"
		[global::Android.Runtime.Register ("com/tencent/open/utils/HttpUtils$HttpStatusException", DoNotGenerateAcw=true)]
		public partial class HttpStatusException : global::Java.Lang.Exception {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils.HttpStatusException']/field[@name='ERROR_INFO']"
			[Register ("ERROR_INFO")]
			public const string ErrorInfo = (string) "http status code error:";
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/open/utils/HttpUtils$HttpStatusException", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HttpStatusException); }
			}

			protected HttpStatusException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils.HttpStatusException']/constructor[@name='HttpUtils.HttpStatusException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe HttpStatusException (string p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (HttpStatusException)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils.MyX509TrustManager']"
		[global::Android.Runtime.Register ("com/tencent/open/utils/HttpUtils$MyX509TrustManager", DoNotGenerateAcw=true)]
		public partial class MyX509TrustManager : global::Java.Lang.Object, global::Javax.Net.Ssl.IX509TrustManager {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/open/utils/HttpUtils$MyX509TrustManager", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MyX509TrustManager); }
			}

			protected MyX509TrustManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetCheckClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Handler ()
			{
				if (cb_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ == null)
					cb_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_);
				return cb_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
			}

			static void n_CheckClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Tencent.Open.Utils.HttpUtils.MyX509TrustManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Utils.HttpUtils.MyX509TrustManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Security.Cert.X509Certificate[] p0 = (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Security.Cert.X509Certificate));
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.CheckClientTrusted (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			static IntPtr id_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils.MyX509TrustManager']/method[@name='checkClientTrusted' and count(parameter)=2 and parameter[1][@type='java.security.cert.X509Certificate[]'] and parameter[2][@type='java.lang.String']]"
			[Register ("checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", "GetCheckClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Handler")]
			public virtual unsafe void CheckClientTrusted (global::Java.Security.Cert.X509Certificate[] p0, string p1)
			{
				if (id_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ == IntPtr.Zero)
					id_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V"), __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetCheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Handler ()
			{
				if (cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ == null)
					cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_);
				return cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
			}

			static void n_CheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Tencent.Open.Utils.HttpUtils.MyX509TrustManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Utils.HttpUtils.MyX509TrustManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Security.Cert.X509Certificate[] p0 = (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Security.Cert.X509Certificate));
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.CheckServerTrusted (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			static IntPtr id_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils.MyX509TrustManager']/method[@name='checkServerTrusted' and count(parameter)=2 and parameter[1][@type='java.security.cert.X509Certificate[]'] and parameter[2][@type='java.lang.String']]"
			[Register ("checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", "GetCheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Handler")]
			public virtual unsafe void CheckServerTrusted (global::Java.Security.Cert.X509Certificate[] p0, string p1)
			{
				if (id_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ == IntPtr.Zero)
					id_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V"), __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_getAcceptedIssuers;
#pragma warning disable 0169
			static Delegate GetGetAcceptedIssuersHandler ()
			{
				if (cb_getAcceptedIssuers == null)
					cb_getAcceptedIssuers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAcceptedIssuers);
				return cb_getAcceptedIssuers;
			}

			static IntPtr n_GetAcceptedIssuers (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Open.Utils.HttpUtils.MyX509TrustManager __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Utils.HttpUtils.MyX509TrustManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetAcceptedIssuers ());
			}
#pragma warning restore 0169

			static IntPtr id_getAcceptedIssuers;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils.MyX509TrustManager']/method[@name='getAcceptedIssuers' and count(parameter)=0]"
			[Register ("getAcceptedIssuers", "()[Ljava/security/cert/X509Certificate;", "GetGetAcceptedIssuersHandler")]
			public virtual unsafe global::Java.Security.Cert.X509Certificate[] GetAcceptedIssuers ()
			{
				if (id_getAcceptedIssuers == IntPtr.Zero)
					id_getAcceptedIssuers = JNIEnv.GetMethodID (class_ref, "getAcceptedIssuers", "()[Ljava/security/cert/X509Certificate;");
				try {

					if (GetType () == ThresholdType)
						return (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getAcceptedIssuers), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Security.Cert.X509Certificate));
					else
						return (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAcceptedIssuers", "()[Ljava/security/cert/X509Certificate;")), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Security.Cert.X509Certificate));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils.NetworkProxy']"
		[global::Android.Runtime.Register ("com/tencent/open/utils/HttpUtils$NetworkProxy", DoNotGenerateAcw=true)]
		public partial class NetworkProxy : global::Java.Lang.Object {


			static IntPtr host_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils.NetworkProxy']/field[@name='host']"
			[Register ("host")]
			public string Host {
				get {
					if (host_jfieldId == IntPtr.Zero)
						host_jfieldId = JNIEnv.GetFieldID (class_ref, "host", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, host_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (host_jfieldId == IntPtr.Zero)
						host_jfieldId = JNIEnv.GetFieldID (class_ref, "host", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, host_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr port_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils.NetworkProxy']/field[@name='port']"
			[Register ("port")]
			public int Port {
				get {
					if (port_jfieldId == IntPtr.Zero)
						port_jfieldId = JNIEnv.GetFieldID (class_ref, "port", "I");
					return JNIEnv.GetIntField (Handle, port_jfieldId);
				}
				set {
					if (port_jfieldId == IntPtr.Zero)
						port_jfieldId = JNIEnv.GetFieldID (class_ref, "port", "I");
					try {
						JNIEnv.SetField (Handle, port_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/open/utils/HttpUtils$NetworkProxy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NetworkProxy); }
			}

			protected NetworkProxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils.NetworkUnavailableException']"
		[global::Android.Runtime.Register ("com/tencent/open/utils/HttpUtils$NetworkUnavailableException", DoNotGenerateAcw=true)]
		public partial class NetworkUnavailableException : global::Java.Lang.Exception {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils.NetworkUnavailableException']/field[@name='ERROR_INFO']"
			[Register ("ERROR_INFO")]
			public const string ErrorInfo = (string) "network unavailable";
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/open/utils/HttpUtils$NetworkUnavailableException", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NetworkUnavailableException); }
			}

			protected NetworkUnavailableException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils.NetworkUnavailableException']/constructor[@name='HttpUtils.NetworkUnavailableException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe NetworkUnavailableException (string p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (NetworkUnavailableException)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/utils/HttpUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpUtils); }
		}

		protected HttpUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_encodePostBody_Landroid_os_Bundle_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils']/method[@name='encodePostBody' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.lang.String']]"
		[Register ("encodePostBody", "(Landroid/os/Bundle;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string EncodePostBody (global::Android.OS.Bundle p0, string p1)
		{
			if (id_encodePostBody_Landroid_os_Bundle_Ljava_lang_String_ == IntPtr.Zero)
				id_encodePostBody_Landroid_os_Bundle_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encodePostBody", "(Landroid/os/Bundle;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodePostBody_Landroid_os_Bundle_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_encodeUrl_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils']/method[@name='encodeUrl' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("encodeUrl", "(Landroid/os/Bundle;)Ljava/lang/String;", "")]
		public static unsafe string EncodeUrl (global::Android.OS.Bundle p0)
		{
			if (id_encodeUrl_Landroid_os_Bundle_ == IntPtr.Zero)
				id_encodeUrl_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "encodeUrl", "(Landroid/os/Bundle;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeUrl_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getErrorCodeFromException_Ljava_io_IOException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils']/method[@name='getErrorCodeFromException' and count(parameter)=1 and parameter[1][@type='java.io.IOException']]"
		[Register ("getErrorCodeFromException", "(Ljava/io/IOException;)I", "")]
		public static unsafe int GetErrorCodeFromException (global::Java.IO.IOException p0)
		{
			if (id_getErrorCodeFromException_Ljava_io_IOException_ == IntPtr.Zero)
				id_getErrorCodeFromException_Ljava_io_IOException_ = JNIEnv.GetStaticMethodID (class_ref, "getErrorCodeFromException", "(Ljava/io/IOException;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getErrorCodeFromException_Ljava_io_IOException_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getHttpClient_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils']/method[@name='getHttpClient' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getHttpClient", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Lorg/apache/http/client/HttpClient;", "")]
		public static unsafe global::Org.Apache.Http.Client.IHttpClient GetHttpClient (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_getHttpClient_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getHttpClient_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getHttpClient", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Lorg/apache/http/client/HttpClient;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::Org.Apache.Http.Client.IHttpClient __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Client.IHttpClient> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getHttpClient_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getProxy_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils']/method[@name='getProxy' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getProxy", "(Landroid/content/Context;)Lcom/tencent/open/utils/HttpUtils$NetworkProxy;", "")]
		public static unsafe global::Com.Tencent.Open.Utils.HttpUtils.NetworkProxy GetProxy (global::Android.Content.Context p0)
		{
			if (id_getProxy_Landroid_content_Context_ == IntPtr.Zero)
				id_getProxy_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getProxy", "(Landroid/content/Context;)Lcom/tencent/open/utils/HttpUtils$NetworkProxy;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Tencent.Open.Utils.HttpUtils.NetworkProxy __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Utils.HttpUtils.NetworkProxy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getProxy_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_openUrl2_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils']/method[@name='openUrl2' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("openUrl2", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Lcom/tencent/open/utils/Util$Statistic;", "")]
		public static unsafe global::Com.Tencent.Open.Utils.Util.Statistic OpenUrl2 (global::Android.Content.Context p0, string p1, string p2, global::Android.OS.Bundle p3)
		{
			if (id_openUrl2_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_openUrl2_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "openUrl2", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Lcom/tencent/open/utils/Util$Statistic;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				global::Com.Tencent.Open.Utils.Util.Statistic __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Utils.Util.Statistic> (JNIEnv.CallStaticObjectMethod  (class_ref, id_openUrl2_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_request_Lcom_tencent_connect_auth_QQToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils']/method[@name='request' and count(parameter)=5 and parameter[1][@type='com.tencent.connect.auth.QQToken'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle'] and parameter[5][@type='java.lang.String']]"
		[Register ("request", "(Lcom/tencent/connect/auth/QQToken;Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/String;)Lorg/json/JSONObject;", "")]
		public static unsafe global::Org.Json.JSONObject Request (global::Com.Tencent.Connect.Auth.QQToken p0, global::Android.Content.Context p1, string p2, global::Android.OS.Bundle p3, string p4)
		{
			if (id_request_Lcom_tencent_connect_auth_QQToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_ == IntPtr.Zero)
				id_request_Lcom_tencent_connect_auth_QQToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "request", "(Lcom/tencent/connect/auth/QQToken;Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/String;)Lorg/json/JSONObject;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_request_Lcom_tencent_connect_auth_QQToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_requestAsync_Lcom_tencent_connect_auth_QQToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_tencent_tauth_IRequestListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils']/method[@name='requestAsync' and count(parameter)=6 and parameter[1][@type='com.tencent.connect.auth.QQToken'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.tencent.tauth.IRequestListener']]"
		[Register ("requestAsync", "(Lcom/tencent/connect/auth/QQToken;Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/String;Lcom/tencent/tauth/IRequestListener;)V", "")]
		public static unsafe void RequestAsync (global::Com.Tencent.Connect.Auth.QQToken p0, global::Android.Content.Context p1, string p2, global::Android.OS.Bundle p3, string p4, global::Com.Tencent.Tauth.IRequestListener p5)
		{
			if (id_requestAsync_Lcom_tencent_connect_auth_QQToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_tencent_tauth_IRequestListener_ == IntPtr.Zero)
				id_requestAsync_Lcom_tencent_connect_auth_QQToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_tencent_tauth_IRequestListener_ = JNIEnv.GetStaticMethodID (class_ref, "requestAsync", "(Lcom/tencent/connect/auth/QQToken;Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;Ljava/lang/String;Lcom/tencent/tauth/IRequestListener;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_requestAsync_Lcom_tencent_connect_auth_QQToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Ljava_lang_String_Lcom_tencent_tauth_IRequestListener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_upload_Lcom_tencent_connect_auth_QQToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='HttpUtils']/method[@name='upload' and count(parameter)=4 and parameter[1][@type='com.tencent.connect.auth.QQToken'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("upload", "(Lcom/tencent/connect/auth/QQToken;Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)Lorg/json/JSONObject;", "")]
		public static unsafe global::Org.Json.JSONObject Upload (global::Com.Tencent.Connect.Auth.QQToken p0, global::Android.Content.Context p1, string p2, global::Android.OS.Bundle p3)
		{
			if (id_upload_Lcom_tencent_connect_auth_QQToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_upload_Lcom_tencent_connect_auth_QQToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "upload", "(Lcom/tencent/connect/auth/QQToken;Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)Lorg/json/JSONObject;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_upload_Lcom_tencent_connect_auth_QQToken_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
