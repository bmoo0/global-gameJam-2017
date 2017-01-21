package com.waveplatform;

import android.app.Activity;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;




/**
 * Created by Sam on 1/20/2017.
 */

public class Note extends Activity {

    Bitmap note;

    public final int LEFT = 1;

    public final int RIGHT = 2;

    public final int UP = 3;

    public final int DOWN = 4;

    private int moving = RIGHT;

    private float x, y;

    private final double GRAVITY = -9.81;

    private final long SPEED = 1000;

    private float length, height;

    private float screenX;

    public Note(int x, int y){
        length = 350;
        height = 350;

        screenX = x;

        this.x = x/2;
        this.y = y-400;

        note = BitmapFactory.decodeResource(this.getResources(), R.drawable.ball);

    }
    public Bitmap getNote(){
        return this.note;
    }
    public void setMovement(int state){
        moving = state;
    }


    public void update(long fps){

    }


}
