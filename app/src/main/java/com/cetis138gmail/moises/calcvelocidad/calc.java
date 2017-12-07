package com.cetis138gmail.moises.calcvelocidad;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class calc extends AppCompatActivity {

    public Button esta, salir,p;
    public EditText q,w,e;
    public EditText z,b,n;
    public TextView vert, verv, verp;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_calc);

        esta = (Button)findViewById(R.id.ver);
        salir = (Button)findViewById(R.id.exit);
        q = (EditText)findViewById(R.id.campot);
        w = (EditText)findViewById(R.id.campov);
        e = (EditText)findViewById(R.id.campop);
        p = (Button)findViewById(R.id.enter);
        z = (EditText)findViewById(R.id.campot2);
        b = (EditText)findViewById(R.id.campov2);
        n = (EditText)findViewById(R.id.campop2);
        vert = (TextView)findViewById(R.id.rcampot2);
        verv = (TextView)findViewById(R.id.rcampov2);
        verp = (TextView)findViewById(R.id.rcampop2);


       esta.setOnClickListener(new View.OnClickListener() {
           @Override
           public void onClick(View v) {
               Intent s = new Intent(calc.this,grafica.class);
               s.addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);
               startActivity(s);
           }
       });

       salir.setOnClickListener(new View.OnClickListener() {
           @Override
           public void onClick(View v) {
            finishAffinity();
            System.exit(0);
           }
       });
       p.setOnClickListener(new View.OnClickListener() {
           @Override
           public void onClick(View v) {
               // codigo de las variables
               double a = Integer.valueOf(q.getText().toString());
               double l = Integer.valueOf(w.getText().toString());
               double c = Integer.valueOf(e.getText().toString());
               double j = Integer.valueOf(z.getText().toString());
               double g = Integer.valueOf(b.getText().toString());
               double h = Integer.valueOf(n.getText().toString());

           //codigo de operacion AQUI EL ORDEN EN COMO LOS ACOMODAS (CODIGO) NO IMPORTA
                double t3=(j*a);
               double vet = l-t3;
               verv.setText(""+vet);

               double vep = (j/a);
               double ra = Math.pow(a,a);
               double ve = vep*ra;
               double veee = vet*a;
               double vee = c-ve-veee;
               verp.setText(""+vee);

           }
       });
    }
}
