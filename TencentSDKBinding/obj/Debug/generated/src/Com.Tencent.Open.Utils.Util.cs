using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']"
	[global::Android.Runtime.Register ("com/tencent/open/utils/Util", DoNotGenerateAcw=true)]
	public partial class Util : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util.Statistic']"
		[global::Android.Runtime.Register ("com/tencent/open/utils/Util$Statistic", DoNotGenerateAcw=true)]
		public partial class Statistic : global::Java.Lang.Object {


			static IntPtr reqSize_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util.Statistic']/field[@name='reqSize']"
			[Register ("reqSize")]
			public long ReqSize {
				get {
					if (reqSize_jfieldId == IntPtr.Zero)
						reqSize_jfieldId = JNIEnv.GetFieldID (class_ref, "reqSize", "J");
					return JNIEnv.GetLongField (Handle, reqSize_jfieldId);
				}
				set {
					if (reqSize_jfieldId == IntPtr.Zero)
						reqSize_jfieldId = JNIEnv.GetFieldID (class_ref, "reqSize", "J");
					try {
						JNIEnv.SetField (Handle, reqSize_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr response_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util.Statistic']/field[@name='response']"
			[Register ("response")]
			public string Response {
				get {
					if (response_jfieldId == IntPtr.Zero)
						response_jfieldId = JNIEnv.GetFieldID (class_ref, "response", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, response_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (response_jfieldId == IntPtr.Zero)
						response_jfieldId = JNIEnv.GetFieldID (class_ref, "response", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, response_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr rspSize_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util.Statistic']/field[@name='rspSize']"
			[Register ("rspSize")]
			public long RspSize {
				get {
					if (rspSize_jfieldId == IntPtr.Zero)
						rspSize_jfieldId = JNIEnv.GetFieldID (class_ref, "rspSize", "J");
					return JNIEnv.GetLongField (Handle, rspSize_jfieldId);
				}
				set {
					if (rspSize_jfieldId == IntPtr.Zero)
						rspSize_jfieldId = JNIEnv.GetFieldID (class_ref, "rspSize", "J");
					try {
						JNIEnv.SetField (Handle, rspSize_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/open/utils/Util$Statistic", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Statistic); }
			}

			protected Statistic (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util.Statistic']/constructor[@name='Util.Statistic' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Ljava/lang/String;I)V", "")]
			public unsafe Statistic (string p0, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (Statistic)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;I)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;I)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_I == IntPtr.Zero)
						id_ctor_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;I)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_I, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_I, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util.TBufferedOutputStream']"
		[global::Android.Runtime.Register ("com/tencent/open/utils/Util$TBufferedOutputStream", DoNotGenerateAcw=true)]
		public partial class TBufferedOutputStream : global::Java.IO.BufferedOutputStream {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/open/utils/Util$TBufferedOutputStream", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TBufferedOutputStream); }
			}

			protected TBufferedOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_io_OutputStream_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util.TBufferedOutputStream']/constructor[@name='Util.TBufferedOutputStream' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
			[Register (".ctor", "(Ljava/io/OutputStream;)V", "")]
			public unsafe TBufferedOutputStream (global::System.IO.Stream p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (TBufferedOutputStream)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/OutputStream;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/OutputStream;)V", __args);
						return;
					}

					if (id_ctor_Ljava_io_OutputStream_ == IntPtr.Zero)
						id_ctor_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/OutputStream;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_OutputStream_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_OutputStream_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_getLength;
#pragma warning disable 0169
			static Delegate GetGetLengthHandler ()
			{
				if (cb_getLength == null)
					cb_getLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLength);
				return cb_getLength;
			}

			static int n_GetLength (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Open.Utils.Util.TBufferedOutputStream __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Utils.Util.TBufferedOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Length;
			}
#pragma warning restore 0169

			static IntPtr id_getLength;
			public virtual unsafe int Length {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util.TBufferedOutputStream']/method[@name='getLength' and count(parameter)=0]"
				[Register ("getLength", "()I", "GetGetLengthHandler")]
				get {
					if (id_getLength == IntPtr.Zero)
						id_getLength = JNIEnv.GetMethodID (class_ref, "getLength", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod  (Handle, id_getLength);
						else
							return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLength", "()I"));
					} finally {
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/utils/Util", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Util); }
		}

		protected Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/constructor[@name='Util' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Util ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Util)) {
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

		static IntPtr id_hasSDCard;
		public static unsafe bool HasSDCard {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='hasSDCard' and count(parameter)=0]"
			[Register ("hasSDCard", "()Z", "GetHasSDCardHandler")]
			get {
				if (id_hasSDCard == IntPtr.Zero)
					id_hasSDCard = JNIEnv.GetStaticMethodID (class_ref, "hasSDCard", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasSDCard);
				} finally {
				}
			}
		}

		static IntPtr id_getUserIp;
		public static unsafe string UserIp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='getUserIp' and count(parameter)=0]"
			[Register ("getUserIp", "()Ljava/lang/String;", "GetGetUserIpHandler")]
			get {
				if (id_getUserIp == IntPtr.Zero)
					id_getUserIp = JNIEnv.GetStaticMethodID (class_ref, "getUserIp", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUserIp), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_checkNetWork_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='checkNetWork' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkNetWork", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool CheckNetWork (global::Android.Content.Context p0)
		{
			if (id_checkNetWork_Landroid_content_Context_ == IntPtr.Zero)
				id_checkNetWork_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkNetWork", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkNetWork_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_composeHaboCgiReportParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='composeHaboCgiReportParams' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='java.lang.String']]"
		[Register ("composeHaboCgiReportParams", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle ComposeHaboCgiReportParams (string p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8)
		{
			if (id_composeHaboCgiReportParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_composeHaboCgiReportParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "composeHaboCgiReportParams", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			IntPtr native_p8 = JNIEnv.NewString (p8);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (native_p7);
				__args [8] = new JValue (native_p8);
				global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_composeHaboCgiReportParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
				JNIEnv.DeleteLocalRef (native_p7);
				JNIEnv.DeleteLocalRef (native_p8);
			}
		}

		static IntPtr id_composeViaReportParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='composeViaReportParams' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("composeViaReportParams", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle ComposeViaReportParams (string p0, string p1, string p2, string p3, string p4, string p5)
		{
			if (id_composeViaReportParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_composeViaReportParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "composeViaReportParams", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_composeViaReportParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_composeViaReportParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='composeViaReportParams' and count(parameter)=12 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='java.lang.String'] and parameter[11][@type='java.lang.String'] and parameter[12][@type='java.lang.String']]"
		[Register ("composeViaReportParams", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle ComposeViaReportParams (string p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9, string p10, string p11)
		{
			if (id_composeViaReportParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_composeViaReportParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "composeViaReportParams", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			IntPtr native_p8 = JNIEnv.NewString (p8);
			IntPtr native_p9 = JNIEnv.NewString (p9);
			IntPtr native_p10 = JNIEnv.NewString (p10);
			IntPtr native_p11 = JNIEnv.NewString (p11);
			try {
				JValue* __args = stackalloc JValue [12];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (native_p7);
				__args [8] = new JValue (native_p8);
				__args [9] = new JValue (native_p9);
				__args [10] = new JValue (native_p10);
				__args [11] = new JValue (native_p11);
				global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_composeViaReportParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
				JNIEnv.DeleteLocalRef (native_p7);
				JNIEnv.DeleteLocalRef (native_p8);
				JNIEnv.DeleteLocalRef (native_p9);
				JNIEnv.DeleteLocalRef (native_p10);
				JNIEnv.DeleteLocalRef (native_p11);
			}
		}

		static IntPtr id_decodeUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='decodeUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeUrl", "(Ljava/lang/String;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle DecodeUrl (string p0)
		{
			if (id_decodeUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeUrl_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeUrl", "(Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_decodeUrlToJson_Lorg_json_JSONObject_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='decodeUrlToJson' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.lang.String']]"
		[Register ("decodeUrlToJson", "(Lorg/json/JSONObject;Ljava/lang/String;)Lorg/json/JSONObject;", "")]
		public static unsafe global::Org.Json.JSONObject DecodeUrlToJson (global::Org.Json.JSONObject p0, string p1)
		{
			if (id_decodeUrlToJson_Lorg_json_JSONObject_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeUrlToJson_Lorg_json_JSONObject_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeUrlToJson", "(Lorg/json/JSONObject;Ljava/lang/String;)Lorg/json/JSONObject;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeUrlToJson_Lorg_json_JSONObject_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_encodePostBody_Landroid_os_Bundle_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='encodePostBody' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='java.lang.String']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='encodeUrl' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
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

		static IntPtr id_encrypt_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='encrypt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encrypt", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Encrypt (string p0)
		{
			if (id_encrypt_Ljava_lang_String_ == IntPtr.Zero)
				id_encrypt_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encrypt", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encrypt_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_fileExists_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='fileExists' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fileExists", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool FileExists (string p0)
		{
			if (id_fileExists_Ljava_lang_String_ == IntPtr.Zero)
				id_fileExists_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fileExists", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_fileExists_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getAppVersion_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='getAppVersion' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppVersion", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetAppVersion (global::Android.Content.Context p0)
		{
			if (id_getAppVersion_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppVersion_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAppVersion", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppVersion_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getAppVersionName_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='getAppVersionName' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
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

		static IntPtr id_getApplicationLable_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='getApplicationLable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getApplicationLable", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetApplicationLable (global::Android.Content.Context p0)
		{
			if (id_getApplicationLable_Landroid_content_Context_ == IntPtr.Zero)
				id_getApplicationLable_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getApplicationLable", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getApplicationLable_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getBytesUTF8_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='getBytesUTF8' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBytesUTF8", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] GetBytesUTF8 (string p0)
		{
			if (id_getBytesUTF8_Ljava_lang_String_ == IntPtr.Zero)
				id_getBytesUTF8_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBytesUTF8", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBytesUTF8_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getLocation_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='getLocation' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getLocation", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetLocation (global::Android.Content.Context p0)
		{
			if (id_getLocation_Landroid_content_Context_ == IntPtr.Zero)
				id_getLocation_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getLocation", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLocation_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getPackageInfo_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='getPackageInfo' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getPackageInfo", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void GetPackageInfo (global::Android.Content.Context p0, string p1)
		{
			if (id_getPackageInfo_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getPackageInfo_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getPackageInfo", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getPackageInfo_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getQUA3_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='getQUA3' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getQUA3", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetQUA3 (global::Android.Content.Context p0, string p1)
		{
			if (id_getQUA3_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getQUA3_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getQUA3", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getQUA3_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getVersionName_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='getVersionName' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getVersionName", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetVersionName (global::Android.Content.Context p0, string p1)
		{
			if (id_getVersionName_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getVersionName_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getVersionName", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVersionName_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_hexToString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='hexToString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hexToString", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string HexToString (string p0)
		{
			if (id_hexToString_Ljava_lang_String_ == IntPtr.Zero)
				id_hexToString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hexToString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hexToString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isEmpty_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isEmpty", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsEmpty (string p0)
		{
			if (id_isEmpty_Ljava_lang_String_ == IntPtr.Zero)
				id_isEmpty_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isEmpty", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEmpty_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isMobileQQSupportShare_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='isMobileQQSupportShare' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isMobileQQSupportShare", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsMobileQQSupportShare (global::Android.Content.Context p0)
		{
			if (id_isMobileQQSupportShare_Landroid_content_Context_ == IntPtr.Zero)
				id_isMobileQQSupportShare_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isMobileQQSupportShare", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isMobileQQSupportShare_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isNumeric_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='isNumeric' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isNumeric", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsNumeric (string p0)
		{
			if (id_isNumeric_Ljava_lang_String_ == IntPtr.Zero)
				id_isNumeric_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isNumeric", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNumeric_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isValidPath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='isValidPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isValidPath", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsValidPath (string p0)
		{
			if (id_isValidPath_Ljava_lang_String_ == IntPtr.Zero)
				id_isValidPath_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isValidPath", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isValidPath_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isValidUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='isValidUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isValidUrl", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsValidUrl (string p0)
		{
			if (id_isValidUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_isValidUrl_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isValidUrl", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isValidUrl_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_openBrowser_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='openBrowser' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("openBrowser", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool OpenBrowser (global::Android.Content.Context p0, string p1)
		{
			if (id_openBrowser_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_openBrowser_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "openBrowser", "(Landroid/content/Context;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_openBrowser_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_parseIntValue_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='parseIntValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseIntValue", "(Ljava/lang/String;)I", "")]
		public static unsafe int ParseIntValue (string p0)
		{
			if (id_parseIntValue_Ljava_lang_String_ == IntPtr.Zero)
				id_parseIntValue_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseIntValue", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_parseIntValue_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_parseIntValue_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='parseIntValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("parseIntValue", "(Ljava/lang/String;I)I", "")]
		public static unsafe int ParseIntValue (string p0, int p1)
		{
			if (id_parseIntValue_Ljava_lang_String_I == IntPtr.Zero)
				id_parseIntValue_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "parseIntValue", "(Ljava/lang/String;I)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_parseIntValue_Ljava_lang_String_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_parseJson_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='parseJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseJson", "(Ljava/lang/String;)Lorg/json/JSONObject;", "")]
		public static unsafe global::Org.Json.JSONObject ParseJson (string p0)
		{
			if (id_parseJson_Ljava_lang_String_ == IntPtr.Zero)
				id_parseJson_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseJson", "(Ljava/lang/String;)Lorg/json/JSONObject;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseJson_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_parseUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='parseUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseUrl", "(Ljava/lang/String;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle ParseUrl (string p0)
		{
			if (id_parseUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_parseUrl_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseUrl", "(Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_parseUrlToJson_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='parseUrlToJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseUrlToJson", "(Ljava/lang/String;)Lorg/json/JSONObject;", "")]
		public static unsafe global::Org.Json.JSONObject ParseUrlToJson (string p0)
		{
			if (id_parseUrlToJson_Ljava_lang_String_ == IntPtr.Zero)
				id_parseUrlToJson_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseUrlToJson", "(Ljava/lang/String;)Lorg/json/JSONObject;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseUrlToJson_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_reportBernoulli_Landroid_content_Context_Ljava_lang_String_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='reportBernoulli' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String']]"
		[Register ("reportBernoulli", "(Landroid/content/Context;Ljava/lang/String;JLjava/lang/String;)V", "")]
		public static unsafe void ReportBernoulli (global::Android.Content.Context p0, string p1, long p2, string p3)
		{
			if (id_reportBernoulli_Landroid_content_Context_Ljava_lang_String_JLjava_lang_String_ == IntPtr.Zero)
				id_reportBernoulli_Landroid_content_Context_Ljava_lang_String_JLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "reportBernoulli", "(Landroid/content/Context;Ljava/lang/String;JLjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reportBernoulli_Landroid_content_Context_Ljava_lang_String_JLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_showAlert_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='showAlert' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("showAlert", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void ShowAlert (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_showAlert_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_showAlert_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "showAlert", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_showAlert_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_subString_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='subString' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("subString", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string SubString (string p0, int p1, string p2, string p3)
		{
			if (id_subString_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_subString_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "subString", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_subString_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_toHexString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='toHexString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("toHexString", "([B)Ljava/lang/String;", "")]
		public static unsafe string ToHexString (byte[] p0)
		{
			if (id_toHexString_arrayB == IntPtr.Zero)
				id_toHexString_arrayB = JNIEnv.GetStaticMethodID (class_ref, "toHexString", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toHexString_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_toHexString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='toHexString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toHexString", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToHexString (string p0)
		{
			if (id_toHexString_Ljava_lang_String_ == IntPtr.Zero)
				id_toHexString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toHexString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toHexString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_upload_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='Util']/method[@name='upload' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("upload", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)Lcom/tencent/open/utils/Util$Statistic;", "")]
		public static unsafe global::Com.Tencent.Open.Utils.Util.Statistic Upload (global::Android.Content.Context p0, string p1, global::Android.OS.Bundle p2)
		{
			if (id_upload_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_upload_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "upload", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)Lcom/tencent/open/utils/Util$Statistic;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::Com.Tencent.Open.Utils.Util.Statistic __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Utils.Util.Statistic> (JNIEnv.CallStaticObjectMethod  (class_ref, id_upload_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
