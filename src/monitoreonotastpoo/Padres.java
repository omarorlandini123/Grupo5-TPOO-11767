/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package monitoreonotastpoo;

/**
 *
 * @author Acer
 */

import java.util.List;

public class Padres {
    private String nombre;
    private String apellidos;
    private String codigoHijo;
    private String codigoPadre;
    
    // Constructor
    public Padres(String nombre, String apellidos, String codigoHijo, String codigoPadre) {
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.codigoHijo = codigoHijo;
        this.codigoPadre = codigoPadre;
    }

    // Getters y Setters
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellidos() {
        return apellidos;
    }

    public void setApellidos(String apellidos) {
        this.apellidos = apellidos;
    }

    public String getCodigoHijo() {
        return codigoHijo;
    }

    public void setCodigoHijo(String codigoHijo) {
        this.codigoHijo = codigoHijo;
    }

    public String getCodigoPadre() {
        return codigoPadre;
    }

    public void setCodigoPadre(String codigoPadre) {
        this.codigoPadre = codigoPadre;
    }
}