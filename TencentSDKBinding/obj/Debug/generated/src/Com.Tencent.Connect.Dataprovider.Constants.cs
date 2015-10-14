using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Connect.Dataprovider {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='Constants']"
	[global::Android.Runtime.Register ("com/tencent/connect/dataprovider/Constants", DoNotGenerateAcw=true)]
	public sealed partial class Constants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='Constants']/field[@name='APPID']"
		[Register ("APPID")]
		public const string Appid = (string) "params_appid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='Constants']/field[@name='CONTENT_DATA']"
		[Register ("CONTENT_DATA")]
		public const string ContentData = (string) "contentData";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='Constants']/field[@name='DATA_TYPE']"
		[Register ("DATA_TYPE")]
		public const string DataType = (string) "contentDataType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='Constants']/field[@name='REQUEST_TYPE']"
		[Register ("REQUEST_TYPE")]
		public const string RequestType = (string) "requestDataTypeFlag";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='Constants']/field[@name='SRC_ACTIVITY_ACTION']"
		[Register ("SRC_ACTIVITY_ACTION")]
		public const string SrcActivityAction = (string) "srcAction";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='Constants']/field[@name='SRC_ACTIVITY_CLASS_NAME']"
		[Register ("SRC_ACTIVITY_CLASS_NAME")]
		public const string SrcActivityClassName = (string) "srcClassName";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='Constants']/field[@name='SRC_PACKAGE_NAME']"
		[Register ("SRC_PACKAGE_NAME")]
		public const string SrcPackageName = (string) "srcPackageName";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/connect/dataprovider/Constants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Constants); }
		}

		internal Constants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.connect.dataprovider']/class[@name='Constants']/constructor[@name='Constants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Constants ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Constants)) {
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
