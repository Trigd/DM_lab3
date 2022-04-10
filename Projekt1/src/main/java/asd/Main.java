package asd;

import javax.swing.*;
import java.awt.*;
import java.util.Scanner;
import java.awt.EventQueue;
import javax.swing.JFrame;

public class Main extends JFrame {
    JFrame f,s;
    Rysunek p;
    Krzywa l;
    public Main(){
        System.out.println("Co chcesz odpalić?");
        Scanner scan = new Scanner(System.in);
        System.out.println("1 - Obrazek 2d \n2 - Gra 2D\n3 - Krzywe Beziera (inicjały)");
        Integer number = scan.nextInt();
        switch (number) {
            case 1:
                f = new JFrame();
                Container c = f.getContentPane();
                c.setLayout(new BorderLayout());
                p = new Rysunek();
                f.setResizable(false);
                c.add(p);
                f.setSize(815,630);
                f.setVisible(true);
                f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
                break;
            case 2:
                new SpaceShip().go();
                break;
            case 3:
                s = new JFrame();
                Container v = s.getContentPane();
                v.setLayout(new BorderLayout());
                l = new Krzywa();
                s.setTitle("Inicjały");
                v.add(l);
                s.setSize(800,600);
                s.setVisible(true);
                s.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
                break;
            default:
                System.out.println("Niepoprawna wartość");
                break;
        }
    }

    public static void main(String args[ ]){


        Main t = new Main();
    }
}
