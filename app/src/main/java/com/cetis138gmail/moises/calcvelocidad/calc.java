package com.cetis138gmail.moises.calcvelocidad;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class calc extends AppCompatActivity {

    public Button esta, clear, p;
    public EditText q, w, e;
    public EditText z, b, n;
    public TextView vert, verv, verp;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_calc);

        esta = (Button) findViewById(R.id.ver);
        clear = (Button) findViewById(R.id.exit);
        q = (EditText) findViewById(R.id.campot);
        w = (EditText) findViewById(R.id.campov);
        e = (EditText) findViewById(R.id.campop);
        p = (Button) findViewById(R.id.enter);
        z = (EditText) findViewById(R.id.campot2);
        b = (EditText) findViewById(R.id.campov2);
        n = (EditText) findViewById(R.id.campop2);
        vert = (TextView) findViewById(R.id.rcampot2);
        verv = (TextView) findViewById(R.id.rcampov2);
        verp = (TextView) findViewById(R.id.rcampop2);


        esta.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(new Intent(calc.this, grafica.class));
            }
        });

        clear.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                q.setText("");
                w.setText("");
                e.setText("");
                z.setText("");
                b.setText("");
                n.setText("");
                vert.setText("tiempoy");
                verv.setText("velocidady");
                verp.setText("posiciony");
            }
        });
        p.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // codigo de las variables
                double a = Integer.valueOf(z.getText().toString());
                double t = Integer.valueOf(q.getText().toString());
                double V = Integer.valueOf(w.getText().toString());
                double P = Integer.valueOf(e.getText().toString());
                double g = Integer.valueOf(b.getText().toString());
                double h = Integer.valueOf(n.getText().toString());

                double V1 = V - (a * t);
                verv.setText(String.valueOf(V1));

                double P1 = P - ((a / 2) * (t * t)) - (V1 * t);
                verp.setText(String.valueOf(P1));

            }
        });
    }
}
