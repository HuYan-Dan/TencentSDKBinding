using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Utils {

	[Register ("com/tencent/open/utils/AsynLoadImgBack")]
	public abstract class AsynLoadImgBack {

		internal AsynLoadImgBack ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/interface[@name='AsynLoadImgBack']/field[@name='LOAD_IMAGE_COMPLETED']"
		[Register ("LOAD_IMAGE_COMPLETED")]
		public const int LoadImageCompleted = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/interface[@name='AsynLoadImgBack']/field[@name='LOAD_IMAGE_IMAGE_FORMAT_ERROR']"
		[Register ("LOAD_IMAGE_IMAGE_FORMAT_ERROR")]
		public const int LoadImageImageFormatError = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/interface[@name='AsynLoadImgBack']/field[@name='LOAD_IMAGE_NO_SDCARD']"
		[Register ("LOAD_IMAGE_NO_SDCARD")]
		public const int LoadImageNoSdcard = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.open.utils']/interface[@name='AsynLoadImgBack']/field[@name='LOAD_IMAGE_PATH_NULL']"
		[Register ("LOAD_IMAGE_PATH_NULL")]
		public const int LoadImagePathNull = (int) 1;
	}

	[global::System.Obsolete ("Use the 'AsynLoadImgBack' type. This type will be removed in a future release.")]
	public abstract class AsynLoadImgBackConsts : AsynLoadImgBack {

		private AsynLoadImgBackConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.open.utils']/interface[@name='AsynLoadImgBack']"
	[Register ("com/tencent/open/utils/AsynLoadImgBack", "", "Com.Tencent.Open.Utils.IAsynLoadImgBackInvoker")]
	public partial interface IAsynLoadImgBack : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/interface[@name='AsynLoadImgBack']/method[@name='batchSaved' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.String&gt;']]"
		[Register ("batchSaved", "(ILjava/util/ArrayList;)V", "GetBatchSaved_ILjava_util_ArrayList_Handler:Com.Tencent.Open.Utils.IAsynLoadImgBackInvoker, TencentSDKBinding_v2.9.3")]
		void BatchSaved (int p0, global::System.Collections.Generic.IList<string> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/interface[@name='AsynLoadImgBack']/method[@name='saved' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("saved", "(ILjava/lang/String;)V", "GetSaved_ILjava_lang_String_Handler:Com.Tencent.Open.Utils.IAsynLoadImgBackInvoker, TencentSDKBinding_v2.9.3")]
		void Saved (int p0, string p1);

	}

	[global::Android.Runtime.Register ("com/tencent/open/utils/AsynLoadImgBack", DoNotGenerateAcw=true)]
	internal class IAsynLoadImgBackInvoker : global::Java.Lang.Object, IAsynLoadImgBack {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/open/utils/AsynLoadImgBack");
		IntPtr class_ref;

		public static IAsynLoadImgBack GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAsynLoadImgBack> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.tencent.open.utils.AsynLoadImgBack"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAsynLoadImgBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAsynLoadImgBackInvoker); }
		}

		static Delegate cb_batchSaved_ILjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetBatchSaved_ILjava_util_ArrayList_Handler ()
		{
			if (cb_batchSaved_ILjava_util_ArrayList_ == null)
				cb_batchSaved_ILjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_BatchSaved_ILjava_util_ArrayList_);
			return cb_batchSaved_ILjava_util_ArrayList_;
		}

		static void n_BatchSaved_ILjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Tencent.Open.Utils.IAsynLoadImgBack __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Utils.IAsynLoadImgBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.BatchSaved (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_batchSaved_ILjava_util_ArrayList_;
		public unsafe void BatchSaved (int p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_batchSaved_ILjava_util_ArrayList_ == IntPtr.Zero)
				id_batchSaved_ILjava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "batchSaved", "(ILjava/util/ArrayList;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (Handle, id_batchSaved_ILjava_util_ArrayList_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_saved_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaved_ILjava_lang_String_Handler ()
		{
			if (cb_saved_ILjava_lang_String_ == null)
				cb_saved_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Saved_ILjava_lang_String_);
			return cb_saved_ILjava_lang_String_;
		}

		static void n_Saved_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Tencent.Open.Utils.IAsynLoadImgBack __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Utils.IAsynLoadImgBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Saved (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_saved_ILjava_lang_String_;
		public unsafe void Saved (int p0, string p1)
		{
			if (id_saved_ILjava_lang_String_ == IntPtr.Zero)
				id_saved_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "saved", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (Handle, id_saved_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
