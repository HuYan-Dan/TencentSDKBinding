using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Connect.Dataprovider {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='ErrorCode']"
	[global::Android.Runtime.Register ("com/tencent/connect/dataprovider/ErrorCode", DoNotGenerateAcw=true)]
	public sealed partial class ErrorCode : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='ErrorCode']/field[@name='FileIsEmpty']"
		[Register ("FileIsEmpty")]
		public const int FileIsEmpty = (int) -9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='ErrorCode']/field[@name='FileNotExist']"
		[Register ("FileNotExist")]
		public const int FileNotExist = (int) -8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='ErrorCode']/field[@name='FileNotInSdCard']"
		[Register ("FileNotInSdCard")]
		public const int FileNotInSdCard = (int) -5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='ErrorCode']/field[@name='FileSizeTooLarge']"
		[Register ("FileSizeTooLarge")]
		public const int FileSizeTooLarge = (int) -6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='ErrorCode']/field[@name='NotFoundReturnActivity']"
		[Register ("NotFoundReturnActivity")]
		public const int NotFoundReturnActivity = (int) -3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='ErrorCode']/field[@name='NotFoundTargetApp']"
		[Register ("NotFoundTargetApp")]
		public const int NotFoundTargetApp = (int) -4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='ErrorCode']/field[@name='NotFromTencentApp']"
		[Register ("NotFromTencentApp")]
		public const int NotFromTencentApp = (int) -2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='ErrorCode']/field[@name='NotSupportThisDataType']"
		[Register ("NotSupportThisDataType")]
		public const int NotSupportThisDataType = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='ErrorCode']/field[@name='PathIsNull']"
		[Register ("PathIsNull")]
		public const int PathIsNull = (int) -7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='ErrorCode']/field[@name='SdCardNotExist']"
		[Register ("SdCardNotExist")]
		public const int SdCardNotExist = (int) -10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='ErrorCode']/field[@name='Success']"
		[Register ("Success")]
		public const int Success = (int) 0;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/connect/dataprovider/ErrorCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ErrorCode); }
		}

		internal ErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='ErrorCode']/constructor[@name='ErrorCode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ErrorCode ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ErrorCode)) {
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

	}
}
