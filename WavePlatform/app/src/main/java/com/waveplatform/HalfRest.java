package com.waveplatform;

import android.app.Activity;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;


public class HalfRest extends Activity {
    private float xPos;
    private float yPos;
    private Bitmap halfRest;
    private final int SPEED = 1000;

    HalfRest(Bitmap n,float x, float y) {
        xPos = x/3 - (n.getWidth()/2);
        yPos = y - 400;
        halfRest = n;
    }

    Bitmap getHalfRest() { return this.halfRest; }

    public void update(long fps) {
        if(fps == 0) fps = 1;
        xPos -= 100;
    }

    public float getX() { return this.xPos; }
    public float getY() { return this.yPos; }
}
