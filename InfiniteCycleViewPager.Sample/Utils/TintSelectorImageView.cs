using System;
using Android.Content;
using Android.Graphics;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace InfiniteCycleViewPager.Sample.Utils
{
    public class TintSelectorImageView : ImageView
    {
        private static Color TINT_SELECTOR_COLOR = Color.ParseColor("#506DD3CE");

        public TintSelectorImageView(Context context) : base (context)
        {
            Clickable = true;
        }

        public TintSelectorImageView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            Clickable = true;
        }

        public TintSelectorImageView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
            Clickable = true;
        }

        public override bool OnTouchEvent(Android.Views.MotionEvent e)
        {
            switch (e.Action) {
            case MotionEventActions.Down:
            case MotionEventActions.Move:
                SetColorFilter(TINT_SELECTOR_COLOR, PorterDuff.Mode.SrcOver);
                PostInvalidate();
            break;
            case MotionEventActions.Up:
            case MotionEventActions.Cancel:
            case MotionEventActions.Outside:
            default:
                ClearColorFilter();
                PostInvalidate();
            break;
        }

            return base.OnTouchEvent(e);
        }
    }
}

