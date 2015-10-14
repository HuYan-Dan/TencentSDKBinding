using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open']/class[@name='a']"
	[global::Android.Runtime.Register ("com/tencent/open/a", DoNotGenerateAcw=true)]
	public partial class A : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open']/class[@name='a.a']"
		[global::Android.Runtime.Register ("com/tencent/open/a$a", DoNotGenerateAcw=true)]
		public partial class a_ : global::Java.Lang.Object {


			static IntPtr b_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='a.a']/field[@name='b']"
			[Register ("b")]
			protected long B {
				get {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "J");
					return JNIEnv.GetLongField (Handle, b_jfieldId);
				}
				set {
					if (b_jfieldId == IntPtr.Zero)
						b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "J");
					try {
						JNIEnv.SetField (Handle, b_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr c_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open']/class[@name='a.a']/field[@name='c']"
			[Register ("c")]
			protected string C {
				get {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, c_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (c_jfieldId == IntPtr.Zero)
						c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, c_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/open/a$a", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (a_); }
			}

			protected a_ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_webkit_WebView_JLjava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open']/class[@name='a.a']/constructor[@name='a.a' and count(parameter)=3 and parameter[1][@type='android.webkit.WebView'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Landroid/webkit/WebView;JLjava/lang/String;)V", "")]
			public unsafe a_ (global::Android.Webkit.WebView p0, long p1, string p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (native_p2);
					if (GetType () != typeof (a_)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/webkit/WebView;JLjava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/webkit/WebView;JLjava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Landroid_webkit_WebView_JLjava_lang_String_ == IntPtr.Zero)
						id_ctor_Landroid_webkit_WebView_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/webkit/WebView;JLjava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_webkit_WebView_JLjava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_webkit_WebView_JLjava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			static Delegate cb_a;
#pragma warning disable 0169
			static Delegate GetAHandler ()
			{
				if (cb_a == null)
					cb_a = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_A);
				return cb_a;
			}

			static void n_A (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Open.A.a_ __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.A.a_> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.A ();
			}
#pragma warning restore 0169

			static IntPtr id_a;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='a.a']/method[@name='a' and count(parameter)=0]"
			[Register ("a", "()V", "GetAHandler")]
			public virtual unsafe void A ()
			{
				if (id_a == IntPtr.Zero)
					id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_a);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "()V"));
				} finally {
				}
			}

			static Delegate cb_a_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetA_Ljava_lang_Object_Handler ()
			{
				if (cb_a_Ljava_lang_Object_ == null)
					cb_a_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_Object_);
				return cb_a_Ljava_lang_Object_;
			}

			static void n_A_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Open.A.a_ __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.A.a_> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.A (p0);
			}
#pragma warning restore 0169

			static IntPtr id_a_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='a.a']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("a", "(Ljava/lang/Object;)V", "GetA_Ljava_lang_Object_Handler")]
			public virtual unsafe void A (global::Java.Lang.Object p0)
			{
				if (id_a_Ljava_lang_Object_ == IntPtr.Zero)
					id_a_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/Object;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_Object_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/lang/Object;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_a_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetA_Ljava_lang_String_Handler ()
			{
				if (cb_a_Ljava_lang_String_ == null)
					cb_a_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Ljava_lang_String_);
				return cb_a_Ljava_lang_String_;
			}

			static void n_A_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Open.A.a_ __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.A.a_> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.A (p0);
			}
#pragma warning restore 0169

			static IntPtr id_a_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='a.a']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("a", "(Ljava/lang/String;)V", "GetA_Ljava_lang_String_Handler")]
			public virtual unsafe void A (string p0)
			{
				if (id_a_Ljava_lang_String_ == IntPtr.Zero)
					id_a_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open']/class[@name='a.b']"
		[global::Android.Runtime.Register ("com/tencent/open/a$b", DoNotGenerateAcw=true)]
		public partial class B : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/open/a$b", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (B); }
			}

			protected B (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open']/class[@name='a.b']/constructor[@name='a.b' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe B ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (B)) {
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

			static Delegate cb_call_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_;
#pragma warning disable 0169
			static Delegate GetCall_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_Handler ()
			{
				if (cb_call_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_ == null)
					cb_call_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Call_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_);
				return cb_call_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_;
			}

			static void n_Call_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Tencent.Open.A.B __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.A.B> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Open.A.a_ p2 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.A.a_> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.Call (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_call_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='a.b']/method[@name='call' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[3][@type='com.tencent.open.a.a']]"
			[Register ("call", "(Ljava/lang/String;Ljava/util/List;Lcom/tencent/open/a$a;)V", "GetCall_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_Handler")]
			public virtual unsafe void Call (string p0, global::System.Collections.Generic.IList<string> p1, global::Com.Tencent.Open.A.a_ p2)
			{
				if (id_call_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_ == IntPtr.Zero)
					id_call_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_ = JNIEnv.GetMethodID (class_ref, "call", "(Ljava/lang/String;Ljava/util/List;Lcom/tencent/open/a$a;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (p2);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_call_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "call", "(Ljava/lang/String;Ljava/util/List;Lcom/tencent/open/a$a;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_customCallback;
#pragma warning disable 0169
			static Delegate GetCustomCallbackHandler ()
			{
				if (cb_customCallback == null)
					cb_customCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CustomCallback);
				return cb_customCallback;
			}

			static bool n_CustomCallback (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Open.A.B __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.A.B> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CustomCallback ();
			}
#pragma warning restore 0169

			static IntPtr id_customCallback;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='a.b']/method[@name='customCallback' and count(parameter)=0]"
			[Register ("customCallback", "()Z", "GetCustomCallbackHandler")]
			public virtual unsafe bool CustomCallback ()
			{
				if (id_customCallback == IntPtr.Zero)
					id_customCallback = JNIEnv.GetMethodID (class_ref, "customCallback", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_customCallback);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "customCallback", "()Z"));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/a", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (A); }
		}

		protected A (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open']/class[@name='a']/constructor[@name='a' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe A ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (A)) {
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

		static Delegate cb_a_Landroid_webkit_WebView_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeA_Landroid_webkit_WebView_Ljava_lang_String_Handler ()
		{
			if (cb_a_Landroid_webkit_WebView_Ljava_lang_String_ == null)
				cb_a_Landroid_webkit_WebView_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_InvokeA_Landroid_webkit_WebView_Ljava_lang_String_);
			return cb_a_Landroid_webkit_WebView_Ljava_lang_String_;
		}

		static bool n_InvokeA_Landroid_webkit_WebView_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Open.A __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.A> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Webkit.WebView p0 = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InvokeA (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_a_Landroid_webkit_WebView_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='a']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.webkit.WebView'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Landroid/webkit/WebView;Ljava/lang/String;)Z", "GetInvokeA_Landroid_webkit_WebView_Ljava_lang_String_Handler")]
		public virtual unsafe bool InvokeA (global::Android.Webkit.WebView p0, string p1)
		{
			if (id_a_Landroid_webkit_WebView_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_webkit_WebView_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/webkit/WebView;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_a_Landroid_webkit_WebView_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Landroid/webkit/WebView;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_a_Lcom_tencent_open_a_b_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeA_Lcom_tencent_open_a_b_Ljava_lang_String_Handler ()
		{
			if (cb_a_Lcom_tencent_open_a_b_Ljava_lang_String_ == null)
				cb_a_Lcom_tencent_open_a_b_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeA_Lcom_tencent_open_a_b_Ljava_lang_String_);
			return cb_a_Lcom_tencent_open_a_b_Ljava_lang_String_;
		}

		static void n_InvokeA_Lcom_tencent_open_a_b_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Open.A __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.A> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Open.A.B p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.A.B> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.InvokeA (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_a_Lcom_tencent_open_a_b_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='a']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.tencent.open.a.b'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Lcom/tencent/open/a$b;Ljava/lang/String;)V", "GetInvokeA_Lcom_tencent_open_a_b_Ljava_lang_String_Handler")]
		public virtual unsafe void InvokeA (global::Com.Tencent.Open.A.B p0, string p1)
		{
			if (id_a_Lcom_tencent_open_a_b_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Lcom_tencent_open_a_b_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/tencent/open/a$b;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_a_Lcom_tencent_open_a_b_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Lcom/tencent/open/a$b;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_a_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_;
#pragma warning disable 0169
		static Delegate GetInvokeA_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_Handler ()
		{
			if (cb_a_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_ == null)
				cb_a_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeA_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_);
			return cb_a_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_;
		}

		static void n_InvokeA_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Tencent.Open.A __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.A> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Open.A.a_ p3 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.A.a_> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.InvokeA (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open']/class[@name='a']/method[@name='a' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[4][@type='com.tencent.open.a.a']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;Lcom/tencent/open/a$a;)V", "GetInvokeA_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_Handler")]
		public virtual unsafe void InvokeA (string p0, string p1, global::System.Collections.Generic.IList<string> p2, global::Com.Tencent.Open.A.a_ p3)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;Lcom/tencent/open/a$a;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_a_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Lcom_tencent_open_a_a_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;Lcom/tencent/open/a$a;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
