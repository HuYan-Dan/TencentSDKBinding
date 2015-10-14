using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='AsynLoadImg']"
	[global::Android.Runtime.Register ("com/tencent/open/utils/AsynLoadImg", DoNotGenerateAcw=true)]
	public partial class AsynLoadImg : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/utils/AsynLoadImg", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsynLoadImg); }
		}

		protected AsynLoadImg (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='AsynLoadImg']/constructor[@name='AsynLoadImg' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register (".ctor", "(Landroid/app/Activity;)V", "")]
		public unsafe AsynLoadImg (global::Android.App.Activity p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AsynLoadImg)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Activity;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/app/Activity;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_getbitmap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='AsynLoadImg']/method[@name='getbitmap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getbitmap", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap Getbitmap (string p0)
		{
			if (id_getbitmap_Ljava_lang_String_ == IntPtr.Zero)
				id_getbitmap_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getbitmap", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getbitmap_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_save_Ljava_lang_String_Lcom_tencent_open_utils_AsynLoadImgBack_;
#pragma warning disable 0169
		static Delegate GetSave_Ljava_lang_String_Lcom_tencent_open_utils_AsynLoadImgBack_Handler ()
		{
			if (cb_save_Ljava_lang_String_Lcom_tencent_open_utils_AsynLoadImgBack_ == null)
				cb_save_Ljava_lang_String_Lcom_tencent_open_utils_AsynLoadImgBack_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Save_Ljava_lang_String_Lcom_tencent_open_utils_AsynLoadImgBack_);
			return cb_save_Ljava_lang_String_Lcom_tencent_open_utils_AsynLoadImgBack_;
		}

		static void n_Save_Ljava_lang_String_Lcom_tencent_open_utils_AsynLoadImgBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Open.Utils.AsynLoadImg __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Utils.AsynLoadImg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Open.Utils.IAsynLoadImgBack p1 = (global::Com.Tencent.Open.Utils.IAsynLoadImgBack)global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Utils.IAsynLoadImgBack> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Save (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_save_Ljava_lang_String_Lcom_tencent_open_utils_AsynLoadImgBack_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='AsynLoadImg']/method[@name='save' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.tencent.open.utils.AsynLoadImgBack']]"
		[Register ("save", "(Ljava/lang/String;Lcom/tencent/open/utils/AsynLoadImgBack;)V", "GetSave_Ljava_lang_String_Lcom_tencent_open_utils_AsynLoadImgBack_Handler")]
		public virtual unsafe void Save (string p0, global::Com.Tencent.Open.Utils.IAsynLoadImgBack p1)
		{
			if (id_save_Ljava_lang_String_Lcom_tencent_open_utils_AsynLoadImgBack_ == IntPtr.Zero)
				id_save_Ljava_lang_String_Lcom_tencent_open_utils_AsynLoadImgBack_ = JNIEnv.GetMethodID (class_ref, "save", "(Ljava/lang/String;Lcom/tencent/open/utils/AsynLoadImgBack;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_save_Ljava_lang_String_Lcom_tencent_open_utils_AsynLoadImgBack_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "save", "(Ljava/lang/String;Lcom/tencent/open/utils/AsynLoadImgBack;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_saveFile_Landroid_graphics_Bitmap_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaveFile_Landroid_graphics_Bitmap_Ljava_lang_String_Handler ()
		{
			if (cb_saveFile_Landroid_graphics_Bitmap_Ljava_lang_String_ == null)
				cb_saveFile_Landroid_graphics_Bitmap_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_SaveFile_Landroid_graphics_Bitmap_Ljava_lang_String_);
			return cb_saveFile_Landroid_graphics_Bitmap_Ljava_lang_String_;
		}

		static bool n_SaveFile_Landroid_graphics_Bitmap_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Open.Utils.AsynLoadImg __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Utils.AsynLoadImg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SaveFile (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_saveFile_Landroid_graphics_Bitmap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.utils']/class[@name='AsynLoadImg']/method[@name='saveFile' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='java.lang.String']]"
		[Register ("saveFile", "(Landroid/graphics/Bitmap;Ljava/lang/String;)Z", "GetSaveFile_Landroid_graphics_Bitmap_Ljava_lang_String_Handler")]
		public virtual unsafe bool SaveFile (global::Android.Graphics.Bitmap p0, string p1)
		{
			if (id_saveFile_Landroid_graphics_Bitmap_Ljava_lang_String_ == IntPtr.Zero)
				id_saveFile_Landroid_graphics_Bitmap_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "saveFile", "(Landroid/graphics/Bitmap;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_saveFile_Landroid_graphics_Bitmap_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveFile", "(Landroid/graphics/Bitmap;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
