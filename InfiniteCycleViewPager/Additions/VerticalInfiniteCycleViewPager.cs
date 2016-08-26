using System;

namespace Com.Gigamole.Infinitecycleviewpager
{
    public partial class VerticalInfiniteCycleViewPager
    {
        protected static bool DEFAULT_DISABLE_FLAG = false;
        protected static bool DEFAULT_ENABLE_FLAG = true;
        protected static int DEFAULT_OFFSCREEN_PAGE_LIMIT = 2;
        protected static int DEFAULT_PAGE_MARGIN = 0;

        public void SetDrawingCacheEnabled(bool enabled)
        {
            SetDrawingCacheEnabled(DEFAULT_DISABLE_FLAG);
        }

        public void SetOffscreenPageLimit(int limit)
        {
            SetOffscreenPageLimit(DEFAULT_OFFSCREEN_PAGE_LIMIT);
        }

        public void SetOverScrollMode(int overScrollMode)
        {
            SetOverScrollMode(2);
        }

        public void SetPageMargin(int marginPixels)
        {
            SetPageMargin(DEFAULT_PAGE_MARGIN);
        }
    }
}

