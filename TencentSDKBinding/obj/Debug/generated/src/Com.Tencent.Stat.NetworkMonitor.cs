using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Stat {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.stat']/class[@name='NetworkMonitor']"
	[global::Android.Runtime.Register ("com/tencent/stat/NetworkMonitor", DoNotGenerateAcw=true)]
	public partial class NetworkMonitor : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/stat/NetworkMonitor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkMonitor); }
		}

		protected NetworkMonitor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.stat']/class[@name='NetworkMonitor']/constructor[@name='NetworkMonitor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NetworkMonitor ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (NetworkMonitor)) {
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

		static Delegate cb_getDomain;
#pragma warning disable 0169
		static Delegate GetGetDomainHandler ()
		{
			if (cb_getDomain == null)
				cb_getDomain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDomain);
			return cb_getDomain;
		}

		static IntPtr n_GetDomain (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.NetworkMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.NetworkMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Domain);
		}
#pragma warning restore 0169

		static Delegate cb_setDomain_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDomain_Ljava_lang_String_Handler ()
		{
			if (cb_setDomain_Ljava_lang_String_ == null)
				cb_setDomain_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDomain_Ljava_lang_String_);
			return cb_setDomain_Ljava_lang_String_;
		}

		static void n_SetDomain_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Stat.NetworkMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.NetworkMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Domain = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDomain;
		static IntPtr id_setDomain_Ljava_lang_String_;
		public virtual unsafe string Domain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='NetworkMonitor']/method[@name='getDomain' and count(parameter)=0]"
			[Register ("getDomain", "()Ljava/lang/String;", "GetGetDomainHandler")]
			get {
				if (id_getDomain == IntPtr.Zero)
					id_getDomain = JNIEnv.GetMethodID (class_ref, "getDomain", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDomain), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDomain", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='NetworkMonitor']/method[@name='setDomain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDomain", "(Ljava/lang/String;)V", "GetSetDomain_Ljava_lang_String_Handler")]
			set {
				if (id_setDomain_Ljava_lang_String_ == IntPtr.Zero)
					id_setDomain_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDomain", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDomain_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDomain", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMillisecondsConsume;
#pragma warning disable 0169
		static Delegate GetGetMillisecondsConsumeHandler ()
		{
			if (cb_getMillisecondsConsume == null)
				cb_getMillisecondsConsume = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMillisecondsConsume);
			return cb_getMillisecondsConsume;
		}

		static long n_GetMillisecondsConsume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.NetworkMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.NetworkMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MillisecondsConsume;
		}
#pragma warning restore 0169

		static Delegate cb_setMillisecondsConsume_J;
#pragma warning disable 0169
		static Delegate GetSetMillisecondsConsume_JHandler ()
		{
			if (cb_setMillisecondsConsume_J == null)
				cb_setMillisecondsConsume_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetMillisecondsConsume_J);
			return cb_setMillisecondsConsume_J;
		}

		static void n_SetMillisecondsConsume_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Tencent.Stat.NetworkMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.NetworkMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MillisecondsConsume = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMillisecondsConsume;
		static IntPtr id_setMillisecondsConsume_J;
		public virtual unsafe long MillisecondsConsume {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='NetworkMonitor']/method[@name='getMillisecondsConsume' and count(parameter)=0]"
			[Register ("getMillisecondsConsume", "()J", "GetGetMillisecondsConsumeHandler")]
			get {
				if (id_getMillisecondsConsume == IntPtr.Zero)
					id_getMillisecondsConsume = JNIEnv.GetMethodID (class_ref, "getMillisecondsConsume", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getMillisecondsConsume);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMillisecondsConsume", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='NetworkMonitor']/method[@name='setMillisecondsConsume' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setMillisecondsConsume", "(J)V", "GetSetMillisecondsConsume_JHandler")]
			set {
				if (id_setMillisecondsConsume_J == IntPtr.Zero)
					id_setMillisecondsConsume_J = JNIEnv.GetMethodID (class_ref, "setMillisecondsConsume", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMillisecondsConsume_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMillisecondsConsume", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPort;
#pragma warning disable 0169
		static Delegate GetGetPortHandler ()
		{
			if (cb_getPort == null)
				cb_getPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPort);
			return cb_getPort;
		}

		static int n_GetPort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.NetworkMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.NetworkMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Port;
		}
#pragma warning restore 0169

		static Delegate cb_setPort_I;
#pragma warning disable 0169
		static Delegate GetSetPort_IHandler ()
		{
			if (cb_setPort_I == null)
				cb_setPort_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPort_I);
			return cb_setPort_I;
		}

		static void n_SetPort_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Stat.NetworkMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.NetworkMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Port = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPort;
		static IntPtr id_setPort_I;
		public virtual unsafe int Port {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='NetworkMonitor']/method[@name='getPort' and count(parameter)=0]"
			[Register ("getPort", "()I", "GetGetPortHandler")]
			get {
				if (id_getPort == IntPtr.Zero)
					id_getPort = JNIEnv.GetMethodID (class_ref, "getPort", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getPort);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPort", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='NetworkMonitor']/method[@name='setPort' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPort", "(I)V", "GetSetPort_IHandler")]
			set {
				if (id_setPort_I == IntPtr.Zero)
					id_setPort_I = JNIEnv.GetMethodID (class_ref, "setPort", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setPort_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPort", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRemoteIp;
#pragma warning disable 0169
		static Delegate GetGetRemoteIpHandler ()
		{
			if (cb_getRemoteIp == null)
				cb_getRemoteIp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRemoteIp);
			return cb_getRemoteIp;
		}

		static IntPtr n_GetRemoteIp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.NetworkMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.NetworkMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RemoteIp);
		}
#pragma warning restore 0169

		static Delegate cb_setRemoteIp_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRemoteIp_Ljava_lang_String_Handler ()
		{
			if (cb_setRemoteIp_Ljava_lang_String_ == null)
				cb_setRemoteIp_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRemoteIp_Ljava_lang_String_);
			return cb_setRemoteIp_Ljava_lang_String_;
		}

		static void n_SetRemoteIp_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Stat.NetworkMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.NetworkMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoteIp = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRemoteIp;
		static IntPtr id_setRemoteIp_Ljava_lang_String_;
		public virtual unsafe string RemoteIp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='NetworkMonitor']/method[@name='getRemoteIp' and count(parameter)=0]"
			[Register ("getRemoteIp", "()Ljava/lang/String;", "GetGetRemoteIpHandler")]
			get {
				if (id_getRemoteIp == IntPtr.Zero)
					id_getRemoteIp = JNIEnv.GetMethodID (class_ref, "getRemoteIp", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRemoteIp), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRemoteIp", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='NetworkMonitor']/method[@name='setRemoteIp' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRemoteIp", "(Ljava/lang/String;)V", "GetSetRemoteIp_Ljava_lang_String_Handler")]
			set {
				if (id_setRemoteIp_Ljava_lang_String_ == IntPtr.Zero)
					id_setRemoteIp_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRemoteIp", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRemoteIp_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRemoteIp", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getStatusCode;
#pragma warning disable 0169
		static Delegate GetGetStatusCodeHandler ()
		{
			if (cb_getStatusCode == null)
				cb_getStatusCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatusCode);
			return cb_getStatusCode;
		}

		static int n_GetStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.NetworkMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.NetworkMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StatusCode;
		}
#pragma warning restore 0169

		static Delegate cb_setStatusCode_I;
#pragma warning disable 0169
		static Delegate GetSetStatusCode_IHandler ()
		{
			if (cb_setStatusCode_I == null)
				cb_setStatusCode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStatusCode_I);
			return cb_setStatusCode_I;
		}

		static void n_SetStatusCode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Stat.NetworkMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.NetworkMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StatusCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStatusCode;
		static IntPtr id_setStatusCode_I;
		public virtual unsafe int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='NetworkMonitor']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "GetGetStatusCodeHandler")]
			get {
				if (id_getStatusCode == IntPtr.Zero)
					id_getStatusCode = JNIEnv.GetMethodID (class_ref, "getStatusCode", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getStatusCode);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatusCode", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='NetworkMonitor']/method[@name='setStatusCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStatusCode", "(I)V", "GetSetStatusCode_IHandler")]
			set {
				if (id_setStatusCode_I == IntPtr.Zero)
					id_setStatusCode_I = JNIEnv.GetMethodID (class_ref, "setStatusCode", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setStatusCode_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatusCode", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_toJSONObject;
#pragma warning disable 0169
		static Delegate GetToJSONObjectHandler ()
		{
			if (cb_toJSONObject == null)
				cb_toJSONObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToJSONObject);
			return cb_toJSONObject;
		}

		static IntPtr n_ToJSONObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Stat.NetworkMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Stat.NetworkMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToJSONObject ());
		}
#pragma warning restore 0169

		static IntPtr id_toJSONObject;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.stat']/class[@name='NetworkMonitor']/method[@name='toJSONObject' and count(parameter)=0]"
		[Register ("toJSONObject", "()Lorg/json/JSONObject;", "GetToJSONObjectHandler")]
		public virtual unsafe global::Org.Json.JSONObject ToJSONObject ()
		{
			if (id_toJSONObject == IntPtr.Zero)
				id_toJSONObject = JNIEnv.GetMethodID (class_ref, "toJSONObject", "()Lorg/json/JSONObject;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_toJSONObject), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toJSONObject", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
