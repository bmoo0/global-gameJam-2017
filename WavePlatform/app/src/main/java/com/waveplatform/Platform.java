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

    public Platform(float x, float y){
        length = 350;
        height = 100;

        screenX = x;
        screenY = y;

        Platform = new RectF(screenX, screenY, length + x, height + y);
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
