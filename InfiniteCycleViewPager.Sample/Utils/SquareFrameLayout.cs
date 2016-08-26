using System;
using Android.Content;
using Android.Util;
using Android.Widget;

namespace InfiniteCycleViewPager.Sample.Utils
{
    public class SquareFrameLayout : FrameLayout
    {
        public SquareFrameLayout(Context context) : base(context)
        {
        }

        public SquareFrameLayout(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            
        }

        public SquareFrameLayout(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
            
        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            int width = MeasureSpec.GetSize(widthMeasureSpec);
            int height = MeasureSpec.GetSize(heightMeasureSpec);

            if (width < height)
            {
                SetMeasuredDimension(width, width);
                base.OnMeasure(widthMeasureSpec, widthMeasureSpec);
            }
            else {
                SetMeasuredDimension(height, height);
                base.OnMeasure(heightMeasureSpec, heightMeasureSpec);
            }
        }
    }
}

