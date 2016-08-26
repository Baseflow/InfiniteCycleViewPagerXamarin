using System;
using Android.Content;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using Com.Gigamole.Infinitecycleviewpager;
using InfiniteCycleViewPager.Sample.Utils;

namespace InfiniteCycleViewPager.Sample.Adapters
{
    public class HorizontalPagerAdapter : PagerAdapter
    {
        private Utils.LibraryObject[] LIBRARIES = new Utils.LibraryObject[]{
            new Utils.LibraryObject(
                    "https://github.com/DevLight-Mobile-Agency/NavigationTabBar",
                    "https://lh4.googleusercontent.com/-mF70XCnMpgk/V1NnK34tnhI/AAAAAAAACkY/z0Z15Q_7gg4fMovWiEvo9agJgz7m933cQCL0B/w323-h552-no/btbntb.gif"
            ),
            new Utils.LibraryObject(
                    "https://github.com/DevLight-Mobile-Agency/NavigationTabStrip",
                    "https://lh6.googleusercontent.com/-wpGnxe1Vefc/VziiygaS9WI/AAAAAAAACd4/c4fU_EG-DHkoby1SIbI5BDtqITpGiZZhwCL0B/w326-h551-no/nts.gif"
            ),
            new Utils.LibraryObject(
                    "https://github.com/DevLight-Mobile-Agency/ShadowLayout",
                    "https://lh4.googleusercontent.com/-2JB-2cEv8lk/Vx4FmHQhjOI/AAAAAAAACTA/nrRGFjcQXBsGiISYSZ5k8gUsVcRw5GSRQCL0B/w349-h552-no/sl.png"
            )
    };

        private Utils.LibraryObject[] TWO_WAY_LIBRARIES = new Utils.LibraryObject[]{
            new Utils.LibraryObject(
                    "https://github.com/DevLight-Mobile-Agency/AnimateFilterCalendarGridLayout",
                    new String[]{
                            "https://lh6.googleusercontent.com/-OMVt5Ow2tsE/VsbvbmJOouI/AAAAAAAACLs/aQoAzX5hGYw/w386-h551-no/afgl.gif",
                            "https://lh4.googleusercontent.com/-dXoUnGjGLHE/VsbvbtehV3I/AAAAAAAACLs/EqYB6AA5fYI/w396-h552-no/acgl.gif"
                    }
            ),
            new Utils.LibraryObject(
                    "https://github.com/DevLight-Mobile-Agency/SlideImageView",
                    new String[]{
                            "https://lh5.googleusercontent.com/-2BiBFz-OW_s/VU_EPv33XMI/AAAAAAAAAcc/nGie_kBoZQ8/w244-h368-no/siv.gif"
                    }
            ),
            new Utils.LibraryObject(
                    "https://github.com/DevLight-Mobile-Agency/MillSpinners",
                    new String[]{
                            "https://lh3.googleusercontent.com/-xmtjZYfrZ3g/VR-7WR2tQ1I/AAAAAAAAAZs/YzLSSYPukYE/s0/multi_arc_spinner.gif",
                            "https://lh5.googleusercontent.com/-PaQXf0zlY5E/VU00AZvffaI/AAAAAAAAAa4/VH36UhvzXl4/w153-h165-no/cws.gif",
                            "https://lh4.googleusercontent.com/-ysG5WmZKG0w/VU00Ao5_MDI/AAAAAAAAAa0/bYf3v90XpcA/w144-h146-no/cs.gif",
                            "https://lh5.googleusercontent.com/-X61M2jmXkTs/VU00AdyLk9I/AAAAAAAAAbI/4BKr42uJ4Vc/w170-h261-no/dls.gif",
                            "https://lh5.googleusercontent.com/-b8PfdN9PoLw/VU00BPNG2cI/AAAAAAAAAbE/AXDZuOMEb5k/w175-h262-no/fs.gif"
                    }
            )
    };

        private Context mContext;
        private LayoutInflater mLayoutInflater;

        private bool mIsTwoWay;

        public HorizontalPagerAdapter(Context context, bool isTwoWay)
        {
            mContext = context;
            mLayoutInflater = LayoutInflater.From(context);
            mIsTwoWay = isTwoWay;
        }

        public override int Count
        {
            get
            {
                return mIsTwoWay ? TWO_WAY_LIBRARIES.Length : LIBRARIES.Length;
            }
        }

        public override int GetItemPosition(Java.Lang.Object objectValue)
        {
            return PositionNone;
        }

        public override Java.Lang.Object InstantiateItem(ViewGroup container, int position)
        {
            View view;
            if (mIsTwoWay)
            {
                view = mLayoutInflater.Inflate(Resource.Layout.two_way_item, container, false);

                var verticalInfiniteCycleViewPager = view.FindViewById<VerticalInfiniteCycleViewPager>(Resource.Id.vicvp);
                verticalInfiniteCycleViewPager.Adapter = new VerticalPagerAdapter(mContext, TWO_WAY_LIBRARIES[position]);
                verticalInfiniteCycleViewPager.CurrentItem = 0;
            }
            else {
                view = mLayoutInflater.Inflate(Resource.Layout.item, container, false);
                AppUtils.SetupImage(mContext, view.FindViewById<ImageView>(Resource.Id.image), LIBRARIES[position]);
            }

            container.AddView(view);
            return view;
        }

        public override bool IsViewFromObject(View view, Java.Lang.Object objectValue)
        {
            return view.Equals(objectValue);
        }

        public override void DestroyItem(ViewGroup container, int position, Java.Lang.Object objectValue)
        {
            container.RemoveView((View)objectValue);
        }
    }
}

