using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='DataConvert']"
	[global::Android.Runtime.Register ("com/tencent/open/utils/DataConvert", DoNotGenerateAcw=true)]
	public partial class DataConvert : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/utils/DataConvert", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataConvert); }
		}

		protected DataConvert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='DataConvert']/constructor[@name='DataConvert' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DataConvert ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DataConvert)) {
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

		static IntPtr id_intToBytes2_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='DataConvert']/method[@name='intToBytes2' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("intToBytes2", "(I)[B", "")]
		public static unsafe byte[] IntToBytes2 (int p0)
		{
			if (id_intToBytes2_I == IntPtr.Zero)
				id_intToBytes2_I = JNIEnv.GetStaticMethodID (class_ref, "intToBytes2", "(I)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_intToBytes2_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_putBytes2Bytes_arrayBarrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='DataConvert']/method[@name='putBytes2Bytes' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("putBytes2Bytes", "([B[BI)I", "")]
		public static unsafe int PutBytes2Bytes (byte[] p0, byte[] p1, int p2)
		{
			if (id_putBytes2Bytes_arrayBarrayBI == IntPtr.Zero)
				id_putBytes2Bytes_arrayBarrayBI = JNIEnv.GetStaticMethodID (class_ref, "putBytes2Bytes", "([B[BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_putBytes2Bytes_arrayBarrayBI, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_putBytes2Bytes_arrayBIarrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='DataConvert']/method[@name='putBytes2Bytes' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
		[Register ("putBytes2Bytes", "([BI[BI)I", "")]
		public static unsafe int PutBytes2Bytes (byte[] p0, int p1, byte[] p2, int p3)
		{
			if (id_putBytes2Bytes_arrayBIarrayBI == IntPtr.Zero)
				id_putBytes2Bytes_arrayBIarrayBI = JNIEnv.GetStaticMethodID (class_ref, "putBytes2Bytes", "([BI[BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_putBytes2Bytes_arrayBIarrayBI, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_putInt2Bytes_IarrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='DataConvert']/method[@name='putInt2Bytes' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("putInt2Bytes", "(I[BI)I", "")]
		public static unsafe int PutInt2Bytes (int p0, byte[] p1, int p2)
		{
			if (id_putInt2Bytes_IarrayBI == IntPtr.Zero)
				id_putInt2Bytes_IarrayBI = JNIEnv.GetStaticMethodID (class_ref, "putInt2Bytes", "(I[BI)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_putInt2Bytes_IarrayBI, __args);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_putShort2Bytes_IarrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='DataConvert']/method[@name='putShort2Bytes' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("putShort2Bytes", "(I[BI)I", "")]
		public static unsafe int PutShort2Bytes (int p0, byte[] p1, int p2)
		{
			if (id_putShort2Bytes_IarrayBI == IntPtr.Zero)
				id_putShort2Bytes_IarrayBI = JNIEnv.GetStaticMethodID (class_ref, "putShort2Bytes", "(I[BI)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_putShort2Bytes_IarrayBI, __args);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_putString2Bytes_Ljava_lang_String_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='DataConvert']/method[@name='putString2Bytes' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("putString2Bytes", "(Ljava/lang/String;[BI)I", "")]
		public static unsafe int PutString2Bytes (string p0, byte[] p1, int p2)
		{
			if (id_putString2Bytes_Ljava_lang_String_arrayBI == IntPtr.Zero)
				id_putString2Bytes_Ljava_lang_String_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "putString2Bytes", "(Ljava/lang/String;[BI)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_putString2Bytes_Ljava_lang_String_arrayBI, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_string2bytes_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='DataConvert']/method[@name='string2bytes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("string2bytes", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] String2bytes (string p0)
		{
			if (id_string2bytes_Ljava_lang_String_ == IntPtr.Zero)
				id_string2bytes_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "string2bytes", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_string2bytes_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_toHexString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='DataConvert']/method[@name='toHexString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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

	}
}
