package asd;
import javax.swing.*;
import java.awt.*;
import static java.lang.StrictMath.pow;

public class Krzywa extends JPanel {
    @Override
    public void paintComponent(Graphics g) {
        super.paintComponent(g);
        Graphics2D g2 = (Graphics2D) g;
        setBackground(Color.CYAN);
        double Px, Py, Gxx, Gyy;
        double[] x = {220,210,160,47,47,27,35,35,35,35,187,92,92,81,36,35,35,34,52,86,86,258,215,223,223,232,196,263,263,327,
                331,334,334,339,342,382,382,419,427,432,432,433,413,485,485,586,587,487,487,415,420,384,384,351,316,227,227,186,225,222,222};
        double[] y = {190,164,25,42,42,45,201,186,186,171,213,302,302,312,201,186,186,171,462,455,455,418,205,200,200,195,456,
                449,449,442,208,233,233,279,309,318,318,326,280,231,231,221,449,446,446,442,61,47,47,37,121,119,119,117,14,40,40,52,213,200,200};
        double[] gx = {518,518,508,508,508,508,487,487,487,487,506,506,506,506,492,492,492,492,519,519,519,519,546,546,546,546,530,530,530,530,552,552,552,
                552,528,528,528,528,518,518,518};
        double[] gy = {13,13,34,34,34,34,44,44,44,44,56,56,56,56,82,82,82,82,66,66,66,66,84,84,84,84,54,54,54,54,45,45,45,
                45,34,34,34,34,13,13,13};
        g2.setColor(Color.yellow);
        for(int i = 0; i <= 9; i++) {
            for(double t = 0; t <=1; t=t+0.001) {
                Gxx = pow(1-t,3) * gx[4*i] + 3 * pow(1-t,2) * t * gx[4*i+1] + 3 * (1-t) * pow(t,2) * gx[4*i+2] + pow(t,3) * gx[4*i+3];
                Gyy = pow(1-t,3) * gy[4*i] + 3 * pow(1-t,2) * t * gy[4*i+1] + 3 * (1-t) * pow(t,2) * gy[4*i+2] + pow(t,3) * gy[4*i+3];
                for(int u = 0; u < 9; u++) {
                    g2.drawLine((int) Gxx + 85, (int) Gyy + u*60, (int) Gxx + 80, (int) Gyy + u*60);
                }
            }
        }
        g2.setColor(Color.BLACK);
        g2.setStroke(new BasicStroke(20f,
                BasicStroke.CAP_SQUARE,
                BasicStroke.JOIN_MITER,
                10));
        for(int i = 0; i <= 14; i++) {
            for(double t = 0; t <=1; t=t+0.001) {
                Px = pow(1-t,3) * x[4*i] + 3 * pow(1-t,2) * t * x[4*i+1] + 3 * (1-t) * pow(t,2) * x[4*i+2] + pow(t,3) * x[4*i+3];
                Py = pow(1-t,3) * y[4*i] + 3 * pow(1-t,2) * t * y[4*i+1] + 3 * (1-t) * pow(t,2) * y[4*i+2] + pow(t,3) * y[4*i+3];
                g2.drawLine((int)Px,(int)Py, (int)Px, (int)Py);
            }
        }
        g2.setColor(Color.RED);
        g2.setStroke(new BasicStroke(10f,
                BasicStroke.CAP_ROUND,
                BasicStroke.JOIN_MITER,
                10));
        for(int i = 0; i <= 60; i++)  {
            g2.drawLine((int)x[i],(int)y[i],(int)x[i],(int)y[i]);
        }
        g2.setColor(Color.white);
        for(int i = 0; i <= 40; i++)  {
            g2.drawLine((int)gx[i],(int)gy[i],(int)gx[i],(int)gy[i]);
        }
    }
}