package com.waveplatform;

import android.app.Activity;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;


public class HalfRest extends Activity {
    private int xPos;
    private int yPos;
    private Bitmap note;

    HalfRest(int x, int y) {
        xPos = x;
        yPos = y;
        //note = // image will go here;
    }

    Bitmap getNote() { return this.note; }

    public void update() {}
}
