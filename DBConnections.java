package com.example.mssab.gojamesandroid;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import java.util.ArrayList;

/**
 * Created by Mssab on 01.02.2017.
 */

public class DBConnections extends SQLiteOpenHelper {
    public static final String DBName="pics.db";
    public static final int Version=1;
    public DBConnections(Context context){
        super(context,DBName,null,Version);

}

    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL("create table IF NOT EXISTs pic (id INTEGER primery key.name TEXT)");

    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("Drop tavble if EXISTS pics");
        onCreate(db);

    }
    public  void InsertRowPics(String name){
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues contentValues = new ContentValues();
        contentValues.put("name",name);
        db.insert("pics",null,contentValues);
    }
    public ArrayList getAllrecord()
    {
        ArrayList array_list=new ArrayList();
        SQLiteDatabase db = this.getReadableDatabase();
        Cursor res = db.rawQuery("select * from pics",null);
        res.moveToFirst();
        while (res.isAfterLast()==false){
            array_list.add(res.getColumnIndex("name"));
            res.moveToNext();
        }
        return array_list;
    }
}



btn{
                EditText txtname=(EditText)findViewById(R.id.testvire);
            ListView ls =(ListView)findViewById(R.id.listview);
            DBConnections db =new DBConnections(this);
            db.InsertRowPics(txtname.toString());
            ArrayList<String> arrlist=db.getAllrecord();
            ls.setAdapter(new ArrayAdapter<>(this,android.R.layout.simple_list_item_1,arrlist));
}