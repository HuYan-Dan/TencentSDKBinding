using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ApkExternalInfoTool']"
	[global::Android.Runtime.Register ("com/tencent/open/utils/ApkExternalInfoTool", DoNotGenerateAcw=true)]
	public sealed partial class ApkExternalInfoTool : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ApkExternalInfoTool']/field[@name='CHANNELID']"
		[Register ("CHANNELID")]
		public const string Channelid = (string) "channelNo";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ApkExternalInfoTool.ApkExternalInfo']"
		[global::Android.Runtime.Register ("com/tencent/open/utils/ApkExternalInfoTool$ApkExternalInfo", DoNotGenerateAcw=true)]
		public partial class ApkExternalInfo : global::Java.Lang.Object {

			protected ApkExternalInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/utils/ApkExternalInfoTool", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApkExternalInfoTool); }
		}

		internal ApkExternalInfoTool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ApkExternalInfoTool']/constructor[@name='ApkExternalInfoTool' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ApkExternalInfoTool ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ApkExternalInfoTool)) {
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

		static IntPtr id_read_Ljava_io_File_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ApkExternalInfoTool']/method[@name='read' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("read", "(Ljava/io/File;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Read (global::Java.IO.File p0, string p1)
		{
			if (id_read_Ljava_io_File_Ljava_lang_String_ == IntPtr.Zero)
				id_read_Ljava_io_File_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Ljava/io/File;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Ljava_io_File_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_readChannelId_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='ApkExternalInfoTool']/method[@name='readChannelId' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("readChannelId", "(Ljava/io/File;)Ljava/lang/String;", "")]
		public static unsafe string ReadChannelId (global::Java.IO.File p0)
		{
			if (id_readChannelId_Ljava_io_File_ == IntPtr.Zero)
				id_readChannelId_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "readChannelId", "(Ljava/io/File;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_readChannelId_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
