package com.waveplatform;

import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.graphics.Rect;

import static android.graphics.Rect.intersects;

/**
 * Created by Sam on 1/20/2017.
 */

public class Sharp {

    Bitmap note;

    private int x, y, y2;

    private Rect Sharp;

    private Rect player;

    public Sharp(Bitmap note, int x, int y){
        this.note = note;
        this.x = x;
        this.y2 = y;
    }

    public boolean checkCollision(Rect player, Rect Sharp){
        this.player = player;
        this.Sharp = Sharp;
        return intersects(player, Sharp);
    }

    public Rect GetBounds(){
        return new Rect(this.x, this.y, this.x + note.getWidth(), this.y+note.getHeight());
    }

    public void Update(){
        //x-=wave.Speed;
        //y = note.getHeight() - Ground.height- note.getHeight()-y2;
    }

    public int returnX(){
        return x;
    }

    public void onDraw(Canvas canvas){
        Update();
        int wide = note.getWidth();
        Rect high = new Rect(0, 0, wide, note.getHeight());
        Rect dist = new Rect(x, y, x + note.getWidth(), y + note.getHeight());
        canvas.drawBitmap(note, high, dist, null);
    }
}
