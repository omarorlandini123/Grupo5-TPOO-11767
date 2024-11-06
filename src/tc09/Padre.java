/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package tc09;

/**
 * Clase que representa a un padre en el sistema.
 * Hereda de Persona y agrega atributos específicos del padre.
 */
public class Padre extends Persona {
    private String telefonoContacto;
    private Estudiante hijo;

    // Constructor
    public Padre(String nombre, String apellido, String dni, String telefonoContacto) {
        super(nombre, apellido, dni);
        this.telefonoContacto = telefonoContacto;
    }

    // Getters y Setters
    public String getTelefonoContacto() {
        return telefonoContacto;
    }

    public void setTelefonoContacto(String telefonoContacto) {
        this.telefonoContacto = telefonoContacto;
    }

    public Estudiante getHijo() {
        return hijo;
    }

    public void setHijo(Estudiante hijo) {
        this.hijo = hijo;
    }
}