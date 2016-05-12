package io.github.moppletop.quickproblems;

import java.util.Scanner;

public class HelloX {

	public static void helloX() {
		System.out.println("What is your name?");

		Scanner scanner = new Scanner(System.in);
		String name = scanner.nextLine();

		System.out.println("Hello " + name);
		scanner.close();
	}

}
