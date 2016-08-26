using System;
using Android.Content;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Util;

namespace InfiniteCycleViewPager.Sample.Utils
{
    public class NonScrollableViewPager : ViewPager
    {
        public NonScrollableViewPager(Context context) : base(context)
        {
            
        }

        public NonScrollableViewPager(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            
        }

        public NonScrollableViewPager(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {

        }

        public override bool OnTouchEvent(Android.Views.MotionEvent e)
        {
            return false;
        }

        public override bool OnInterceptTouchEvent(Android.Views.MotionEvent ev)
        {
            return false;
        }
    }
}

