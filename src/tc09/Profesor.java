/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package tc09;

import java.util.List;

/**
 * Clase que representa a un profesor en el sistema.
 * Hereda de Persona y agrega atributos específicos del profesor.
 */
public class Profesor extends Persona {
    private String asignatura;
    private double salario;
    private List<Materia> materias;

    // Constructor
    public Profesor(String nombre, String apellido, String dni, String asignatura, double salario) {
        super(nombre, apellido, dni);
        this.asignatura = asignatura;
        this.salario = salario;
    }

    // Getters y Setters
    public String getAsignatura() {
        return asignatura;
    }

    public void setAsignatura(String asignatura) {
        this.asignatura = asignatura;
    }

    public double getSalario() {
        return salario;
    }

    public void setSalario(double salario) {
        this.salario = salario;
    }

    public List<Materia> getMaterias() {
        return materias;
    }

    public void setMaterias(List<Materia> materias) {
        this.materias = materias;
    }
}