/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package tc09;

/**
 * Clase que representa a un estudiante en el sistema.
 * Hereda de Persona y agrega atributos específicos del estudiante.
 */
public class Estudiante extends Persona {
    private String codigoEstudiante;
    private double promedioGeneral;
    private Boletin boletin;

    // Constructor
    public Estudiante(String nombre, String apellido, String dni, String codigoEstudiante) {
        super(nombre, apellido, dni);
        this.codigoEstudiante = codigoEstudiante;
    }

    // Getters y Setters
    public String getCodigoEstudiante() {
        return codigoEstudiante;
    }

    public void setCodigoEstudiante(String codigoEstudiante) {
        this.codigoEstudiante = codigoEstudiante;
    }

    public double getPromedioGeneral() {
        return promedioGeneral;
    }

    public void setPromedioGeneral(double promedioGeneral) {
        this.promedioGeneral = promedioGeneral;
    }

    public Boletin getBoletin() {
        return boletin;
    }

    public void setBoletin(Boletin boletin) {
        this.boletin = boletin;
    }
}