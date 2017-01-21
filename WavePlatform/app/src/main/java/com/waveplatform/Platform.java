package com.waveplatform;

import android.app.Activity;
import android.graphics.RectF;

/**
 * Created by Sam on 1/20/2017.
 */

public class Platform extends Activity {

    RectF Platform;
    private float length;
    private float height;
    private float screenX;
    private float screenY;
    private final float SPEED = 1000;

    public Platform(double x, double y){
        length = 350;
        height = 100;

        screenX = (float)x;
        screenY = (float)y;

        Platform = new RectF(screenX, screenY, length + (float)x, height + (float)y);
    }
    public RectF getPlatform(){
        return this.Platform;
    }
    public void update(float fps){
        screenX = screenX - SPEED/fps;

        Platform.left = screenX;
        Platform.right = screenX + length;
    }
}
