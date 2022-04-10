package asd;

import javax.swing.*;
import java.awt.*;

public class Rocket {


    public static final int WIDTH = 800, HEIGHT = 600;
    public float x, y, vx, vy;
    public static final int RAD = 30;
    private Image img;

    public Rocket() {
        x = Rocket.WIDTH/2;
        y = Rocket.HEIGHT/2;

        ImageIcon rocket = new ImageIcon("src/main/resources/rocket.png");
        img = rocket.getImage();
    }

    public void physics() {
        x+=vx;
        y+=vy;
        vy+=0.5f;
    }

    public void update(Graphics g) {
        g.setColor(Color.BLACK);
        g.drawImage(img, Math.round(x-RAD),Math.round(y-RAD),2*RAD,2*RAD, null);
    }

    public void fly() {
        vy = -8;
    }

    public void reset() {
        x = 800/2;
        y = 600/2;
        vx = vy = 0;
    }
}
