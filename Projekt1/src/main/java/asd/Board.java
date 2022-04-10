package asd;
import java.awt.*;
import java.awt.geom.AffineTransform;
import java.util.ArrayList;
import javax.swing.*;

import static asd.SpaceShip.stars;

public class Board extends JPanel {

    private Rocket rocket;
    private ArrayList<Rectangle> rects;
    private SpaceShip fb;
    private Font scoreFont, pauseFont;
    public static final int Laser_W = 50, Laser_H = 30;
    private Image laser1, laser2;

    public Board(SpaceShip fb, Rocket rocket, ArrayList<Rectangle> rects) {
        this.fb = fb;
        this.rocket = rocket;
        this.rects = rects;
        scoreFont = new Font("Comic Sans MS", Font.BOLD, 18);
        pauseFont = new Font("Arial", Font.BOLD, 48);

        ImageIcon l1 = new ImageIcon("src/main/resources/laser1.png");
        laser1 = l1.getImage();
        ImageIcon l2 = new ImageIcon("src/main/resources/laser2.png");
        laser2 = l2.getImage();

    }

    @Override
    public void paintComponent(Graphics g) {
        super.paintComponent(g);
        g.drawImage(stars,0,0,null);
        g.fillRect(0,0,WIDTH,HEIGHT);
        rocket.update(g);
        for(Rectangle r : rects) {
            Graphics2D g2d = (Graphics2D) g;
            g2d.setColor(Color.GREEN);
            //g2d.fillRect(r.x, r.y, r.width, r.height);
            AffineTransform old = g2d.getTransform();
            g2d.translate(r.x+ Laser_W /2 , r.y+ Laser_H /2 );
            if(r.y < SpaceShip.HEIGHT/2) {
                g2d.translate(-17, r.height-30);
                g2d.rotate(Math.PI);
            }
            g2d.drawImage(laser2, -Laser_W, -Laser_H /2+5, Board.Laser_W, Board.Laser_H, null);
            g2d.drawImage(laser1, -Laser_W, Laser_H /2, Board.Laser_W, r.height, null);
            g2d.setTransform(old);
        }
        g.setFont(scoreFont);
        g.setColor(Color.WHITE);
        g.drawString("Score: "+fb.getScore(), 10, 20);

        if(fb.paused()) {
            g.setFont(pauseFont);
            g.setColor(Color.YELLOW);
            g.drawString("PAUSED", SpaceShip.WIDTH/2-100, SpaceShip.HEIGHT/2-100);
            g.drawString("PRESS SPACE TO BEGIN", SpaceShip.WIDTH/2-300, SpaceShip.HEIGHT/2+50);
        }
    }
}

