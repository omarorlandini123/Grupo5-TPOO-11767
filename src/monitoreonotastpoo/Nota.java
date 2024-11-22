/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package monitoreonotastpoo;

/**
 *
 * @author Acer
 */
public class Nota {
    private String codNota;
    private String codEstudiante;
    private String calificacion;
    private String curso;

    // Constructor
    public Nota(String codNota, String codEstudiante, String calificacion, String curso) {
        this.codNota = codNota;
        this.codEstudiante = codEstudiante;
        this.calificacion = calificacion;
        this.curso = curso;
    }

    // Métodos getters y setters
    public String getCodNota() {
        return codNota;
    }

    public void setCodNota(String codNota) {
        this.codNota = codNota;
    }

    public String getCodEstudiante() {
        return codEstudiante;
    }

    public void setCodEstudiante(String codEstudiante) {
        this.codEstudiante = codEstudiante;
    }

    public String getCalificacion() {
        return calificacion;
    }

    public void setCalificacion(String calificacion) {
        this.calificacion = calificacion;
    }

    public String getCurso() {
        return curso;
    }

    public void setCurso(String curso) {
        this.curso = curso;
    }
}