using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Open.Yyb {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='MoreFloatingDialog']"
	[global::Android.Runtime.Register ("com/tencent/open/yyb/MoreFloatingDialog", DoNotGenerateAcw=true)]
	public partial class MoreFloatingDialog : global::Android.App.Dialog {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/open/yyb/MoreFloatingDialog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoreFloatingDialog); }
		}

		protected MoreFloatingDialog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='MoreFloatingDialog']/constructor[@name='MoreFloatingDialog' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MoreFloatingDialog (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MoreFloatingDialog)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getContentViewHeight;
#pragma warning disable 0169
		static Delegate GetGetContentViewHeightHandler ()
		{
			if (cb_getContentViewHeight == null)
				cb_getContentViewHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetContentViewHeight);
			return cb_getContentViewHeight;
		}

		static int n_GetContentViewHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Yyb.MoreFloatingDialog __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.MoreFloatingDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentViewHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getContentViewHeight;
		public virtual unsafe int ContentViewHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='MoreFloatingDialog']/method[@name='getContentViewHeight' and count(parameter)=0]"
			[Register ("getContentViewHeight", "()I", "GetGetContentViewHeightHandler")]
			get {
				if (id_getContentViewHeight == IntPtr.Zero)
					id_getContentViewHeight = JNIEnv.GetMethodID (class_ref, "getContentViewHeight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getContentViewHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentViewHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Yyb.MoreFloatingDialog __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.MoreFloatingDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='MoreFloatingDialog']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getQQItem;
#pragma warning disable 0169
		static Delegate GetGetQQItemHandler ()
		{
			if (cb_getQQItem == null)
				cb_getQQItem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetQQItem);
			return cb_getQQItem;
		}

		static IntPtr n_GetQQItem (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Yyb.MoreFloatingDialog __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.MoreFloatingDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.QQItem);
		}
#pragma warning restore 0169

		static IntPtr id_getQQItem;
		public virtual unsafe global::Android.Views.View QQItem {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='MoreFloatingDialog']/method[@name='getQQItem' and count(parameter)=0]"
			[Register ("getQQItem", "()Landroid/view/View;", "GetGetQQItemHandler")]
			get {
				if (id_getQQItem == IntPtr.Zero)
					id_getQQItem = JNIEnv.GetMethodID (class_ref, "getQQItem", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getQQItem), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQQItem", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getQzoneItem;
#pragma warning disable 0169
		static Delegate GetGetQzoneItemHandler ()
		{
			if (cb_getQzoneItem == null)
				cb_getQzoneItem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetQzoneItem);
			return cb_getQzoneItem;
		}

		static IntPtr n_GetQzoneItem (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Yyb.MoreFloatingDialog __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.MoreFloatingDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.QzoneItem);
		}
#pragma warning restore 0169

		static IntPtr id_getQzoneItem;
		public virtual unsafe global::Android.Views.View QzoneItem {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='MoreFloatingDialog']/method[@name='getQzoneItem' and count(parameter)=0]"
			[Register ("getQzoneItem", "()Landroid/view/View;", "GetGetQzoneItemHandler")]
			get {
				if (id_getQzoneItem == IntPtr.Zero)
					id_getQzoneItem = JNIEnv.GetMethodID (class_ref, "getQzoneItem", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getQzoneItem), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQzoneItem", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimelineItem;
#pragma warning disable 0169
		static Delegate GetGetTimelineItemHandler ()
		{
			if (cb_getTimelineItem == null)
				cb_getTimelineItem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimelineItem);
			return cb_getTimelineItem;
		}

		static IntPtr n_GetTimelineItem (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Yyb.MoreFloatingDialog __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.MoreFloatingDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TimelineItem);
		}
#pragma warning restore 0169

		static IntPtr id_getTimelineItem;
		public virtual unsafe global::Android.Views.View TimelineItem {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='MoreFloatingDialog']/method[@name='getTimelineItem' and count(parameter)=0]"
			[Register ("getTimelineItem", "()Landroid/view/View;", "GetGetTimelineItemHandler")]
			get {
				if (id_getTimelineItem == IntPtr.Zero)
					id_getTimelineItem = JNIEnv.GetMethodID (class_ref, "getTimelineItem", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getTimelineItem), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimelineItem", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWXItem;
#pragma warning disable 0169
		static Delegate GetGetWXItemHandler ()
		{
			if (cb_getWXItem == null)
				cb_getWXItem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWXItem);
			return cb_getWXItem;
		}

		static IntPtr n_GetWXItem (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Open.Yyb.MoreFloatingDialog __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.MoreFloatingDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WXItem);
		}
#pragma warning restore 0169

		static IntPtr id_getWXItem;
		public virtual unsafe global::Android.Views.View WXItem {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='MoreFloatingDialog']/method[@name='getWXItem' and count(parameter)=0]"
			[Register ("getWXItem", "()Landroid/view/View;", "GetGetWXItemHandler")]
			get {
				if (id_getWXItem == IntPtr.Zero)
					id_getWXItem = JNIEnv.GetMethodID (class_ref, "getWXItem", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getWXItem), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWXItem", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_dip2px_F;
#pragma warning disable 0169
		static Delegate GetDip2px_FHandler ()
		{
			if (cb_dip2px_F == null)
				cb_dip2px_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, int>) n_Dip2px_F);
			return cb_dip2px_F;
		}

		static int n_Dip2px_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Tencent.Open.Yyb.MoreFloatingDialog __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Open.Yyb.MoreFloatingDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Dip2px (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dip2px_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.open.yyb']/class[@name='MoreFloatingDialog']/method[@name='dip2px' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("dip2px", "(F)I", "GetDip2px_FHandler")]
		public virtual unsafe int Dip2px (float p0)
		{
			if (id_dip2px_F == IntPtr.Zero)
				id_dip2px_F = JNIEnv.GetMethodID (class_ref, "dip2px", "(F)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_dip2px_F, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dip2px", "(F)I"), __args);
			} finally {
			}
		}

	}
}
