package com.waveplatform;

import android.app.Activity;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;




/**
 * Created by Sam on 1/20/2017.
 */

public class Note extends Activity {

    Bitmap note;

    public final int STOP = 1;

    public final int UP = 2;

    public final int DOWN = 3;

    private int moving = STOP;

    private float x, y;

    private final double GRAVITY = -9.81;

    private final long SPEED = 1000;

    private float length, height;

    private float screenX;

    public Note(Bitmap n, int x, int y){
        screenX = x;

        this.x = x/3 - (n.getWidth()/2);
        this.y = y-400;

        note = n;

    }
    public Bitmap getNote(){
        return this.note;
    }

    public float getX(){
        return x;
    }
    public float getY(){
        return y;
    }

    public void setMovement(int state){
        moving = state;
    }


    public void update(long fps){
        if (moving == UP){
            y = y + 100;
            if (note.getHeight() >= 0)
                y = y - 1;
        }
        if (moving == DOWN)
        {
            y = y - SPEED/fps;
        }

    }


}
