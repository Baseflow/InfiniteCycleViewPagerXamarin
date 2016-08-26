using System;
using Android.Content;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using InfiniteCycleViewPager.Sample.Utils;

namespace InfiniteCycleViewPager.Sample.Adapters
{
    public class VerticalPagerAdapter : PagerAdapter
    {
        private Utils.LibraryObject[] LIBRARIES = new Utils.LibraryObject[]{
            new Utils.LibraryObject(
                    "https://github.com/DevLight-Mobile-Agency/PulseView",
                    "https://lh4.googleusercontent.com/-mqVBaXK0XM0/VyhroJmmU7I/AAAAAAAACUs/OmfzeRZsYNQhNAdgFmKvFIU5XDiJ3-z3wCL0B/w401-h689-no/pv.gif"
            ),
            new Utils.LibraryObject(
                    "https://github.com/DevLight-Mobile-Agency/ArcProgressStackView",
                    "https://lh3.googleusercontent.com/-5wahrBgdCTw/VuwHChXS3FI/AAAAAAAACNQ/eqpqhfnN5G0l3EnETDQ_I5qu4kqQYSysA/w327-h551-no/apsv_preview_size_cb.gif"
            ),
            new Utils.LibraryObject(
                    "https://github.com/DevLight-Mobile-Agency/CutIntoLayout",
                    "https://lh3.googleusercontent.com/fWz9orE3M8vaAuzkxHi0F2m23iuHUYlXmG-lgonEFCU=w210-h282-no"
            ),
            new Utils.LibraryObject(
                    "https://github.com/DevLight-Mobile-Agency/TintLayout",
                    "https://lh3.googleusercontent.com/zwCLyDjZMVM2O571j6gwReHbkAolr7DV3XyKy5hqTug=s308-no"
            )
    };

        private Context mContext;
        private LayoutInflater mLayoutInflater;

        private Utils.LibraryObject mLibraryObject;

        public VerticalPagerAdapter(Context context, Utils.LibraryObject libraryObject)
        {
            mContext = context;
            mLayoutInflater = LayoutInflater.From(context);
            mLibraryObject = libraryObject;
        }

        public override int Count
        {
            get
            {
                return mLibraryObject == null ? LIBRARIES.Length : mLibraryObject.getImages().Length;
            }
        }

        public override int GetItemPosition(Java.Lang.Object objectValue)
        {
            return PositionNone;
        }

        public override Java.Lang.Object InstantiateItem(ViewGroup container, int position)
        {
            View view = mLayoutInflater.Inflate(Resource.Layout.item, container, false);

            if (mLibraryObject == null)
                AppUtils.SetupImage(mContext, view.FindViewById<ImageView>(Resource.Id.image), LIBRARIES[position]);
            else
                AppUtils.SetupImage(mContext, view.FindViewById<ImageView>(Resource.Id.image), mLibraryObject, position);

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

