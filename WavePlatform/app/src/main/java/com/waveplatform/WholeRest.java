package com.waveplatform;

import android.app.Activity;
import android.graphics.Bitmap;

/**
 * Created by Sam on 1/20/2017.
 */

public class WholeRest extends Activity {
    private int xPos;
    private int yPos;
    private Bitmap note;

    WholeRest(int x, int y) {
        xPos = x;
        yPos = y;
        //note = // image will go here;
    }

    Bitmap getNote() { return this.note; }

    public void update() {}
}
