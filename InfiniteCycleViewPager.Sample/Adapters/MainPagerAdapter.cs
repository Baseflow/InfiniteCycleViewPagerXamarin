using System;
using Android.Support.V4.App;
using InfiniteCycleViewPager.Sample.Screens;

namespace InfiniteCycleViewPager.Sample.Adapters
{
    public class MainPagerAdapter : FragmentStatePagerAdapter
    {
        private static int COUNT = 3;

        private const int HORIZONTAL = 0;
        private const int VERTICAL = 1;
        private const int TWO_WAY = 2;

        public MainPagerAdapter(FragmentManager fm) : base(fm)
        {
        }

        public override Fragment GetItem(int position)
        {
            switch (position)
            {
                case VERTICAL:
                    return new VerticalPagerFragment();
                case TWO_WAY:
                    return new TwoWayPagerFragment();
                case HORIZONTAL:
                default:
                    return new HorizontalPagerFragment();
            }
        }

        public override int Count
        {
            get
            {
                return COUNT;
            }
        }
    }
}

