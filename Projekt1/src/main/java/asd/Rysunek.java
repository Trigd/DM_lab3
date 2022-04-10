package asd;
import javax.swing.*;
import java.awt.*;
public class Rysunek extends JPanel {
    @Override
    public void paintComponent(Graphics g) {
        super.paintComponent(g);
        Graphics2D g2 = (Graphics2D) g;
        setBackground(Color.CYAN);
        g2.setColor(Color.yellow);
        g2.fillOval(650, 10, 100, 100);
        g2.drawLine(600, 5, 650, 18);
        g2.drawLine(590, 30, 630, 37);
        g2.drawLine(600, 55, 635, 55);
        g2.drawLine(590, 85, 630, 75);
        g2.drawLine(595, 120, 635, 100);
        g2.drawLine(620, 150, 650, 120);
        g2.drawLine(660, 160, 670, 135);
        g2.drawLine(685, 175, 690, 135);
        g2.drawLine(712, 165, 710, 130);
        g2.drawLine(735, 170, 730, 132);
        g2.drawLine(760, 155, 750, 125);
        g2.setColor(Color.GREEN.darker());
        g2.fillRect(0,300,800,300);
        g2.setColor(Color.darkGray);
        for (int i = 0; i < 27; i++) {
            g2.fillRect(0 + i * 30,520,20,80);
            g2.fillPolygon(new int[] {0 + i * 30, 10 + i * 30, 20 + i * 30}, new int[] {520, 510, 520}, 3);
        }
        for (int i = 0; i < 27; i++) {
            g2.fillRect(0 + i * 30,260,20,80);
            g2.fillPolygon(new int[] {0 + i * 30, 10 + i * 30, 20 + i * 30}, new int[] {260, 250, 260}, 3);
        }
        g2.fillRect(0,570,800,8);
        g2.fillRect(0,535,800,8);
        g2.fillRect(0,310,800,8);
        g2.fillRect(0,275,800,8);

        g2.setColor(Color.orange);
        g2.fillRect(80,200,400,300);

        g2.setColor(Color.darkGray);
        g2.fillRect(120,360,90,140);
        g2.fillRect(380,110,40,60);

        g2.setColor(Color.red.darker());
        g2.fillPolygon(new int[] {80,280,480}, new int[] {200, 80, 200}, 3);
        g2.fillPolygon(new int[] {550,600,650}, new int[] {300, 260, 300}, 3);

        g2.setColor(Color.white);
        g2.fillRect(130,420,15,8);
        g2.fillRect(330,220,100,100);
        g2.fillRect(120,220,100,100);
        g2.fillRect(280,360,150,100);
        g2.fillOval(-50,-50,100,100);
        g2.fillOval(0,-50,150,110);
        g2.fillOval(100,-50,100,110);
        g2.fillOval(120,-50,120,90);

        g2.setColor(Color.BLUE);
        g2.fillRect(340,230,80,80);
        g2.fillRect(130,230,80,80);
        g2.fillRect(290,370,130,80);

        g2.setColor(Color.white);
        g2.fillRect(330,370,10,80);
        g2.fillRect(378,230,4,80);
        g2.fillRect(340,268,80,4);
        g2.fillRect(168,230,4,80);
        g2.fillRect(130,268,80,4);
        g2.fillRect(378,370,4,80);
        g2.fillRect(280,408,140,4);
        g2.fillRect(307,370,4,80);

        g2.setColor(Color.orange.darker());
        g2.fillRect(550,300,100,100);

        g2.setColor(Color.black);
        g2.fillOval(565,310,70,70);
        g2.fillRect(660,395,45,25);
        g2.fillRect(660,375,20,20);
        g2.fillRect(600,420,80,40);
        g2.fillRect(680,450,25,10);
        g2.fillRect(600,460,35,5);
        g2.fillRect(587,420,10,30);
        g2.fillRect(595,420,5,10);
    }
}