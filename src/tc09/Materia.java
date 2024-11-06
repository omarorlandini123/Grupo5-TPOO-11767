/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package tc09;
/**
 * Clase que representa una materia en el sistema.
 * Cada materia es enseñada por un profesor y tiene varios estudiantes.
 * Relación de Agregación entre Profesor y Materia
 */
public class Materia {
    private String nombre;
    private String codigoMateria;
    private Profesor profesor;

    // Constructor
    public Materia(String nombre, String codigoMateria, Profesor profesor) {
        this.nombre = nombre;
        this.codigoMateria = codigoMateria;
        this.profesor = profesor;
    }

    // Getters y Setters
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getCodigoMateria() {
        return codigoMateria;
    }

    public void setCodigoMateria(String codigoMateria) {
        this.codigoMateria = codigoMateria;
    }

    public Profesor getProfesor() {
        return profesor;
    }

    public void setProfesor(Profesor profesor) {
        this.profesor = profesor;
    }
}
