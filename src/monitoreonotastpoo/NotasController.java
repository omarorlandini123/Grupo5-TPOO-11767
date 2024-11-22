/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package monitoreonotastpoo;

/**
 *
 * @author Acer
 */

 import java.util.ArrayList;
import java.util.List;

public class NotasController {
    private static List<Nota> todasLasNotas = new ArrayList<>();

    static {
        // Llenamos la lista con algunas notas de ejemplo
        todasLasNotas.add(new Nota("C001", "N001", "8", "E001"));
        todasLasNotas.add(new Nota("C002", "N002", "7", "E001"));
        todasLasNotas.add(new Nota("C001", "N003", "3", "E002"));
    }

    // Lista estática de notas
    private static List<Nota> listaNotas = new ArrayList<>();

    // Método para obtener todas las notas
    public static List<Nota> obtenerNotas() {
        return listaNotas;
    }

    // Método para agregar una nueva nota
    public static void agregarNota(Nota nuevaNota) {
        listaNotas.add(nuevaNota);
    }

    // Método para editar una nota en la lista
    public static void editarNota(String codNota, Nota nuevaNota) {
        for (int i = 0; i < listaNotas.size(); i++) {
            Nota nota = listaNotas.get(i);
            if (nota.getCodNota().equals(codNota)) {
                listaNotas.set(i, nuevaNota);  // Actualizar la nota
                return;
            }
        }
    }

     // Método para obtener las notas de un estudiante por su código
    public static List<Nota> obtenerNotasPorEstudiante(String codEstudiante) {
        List<Nota> listaNotasEstudiante = new ArrayList<>();
        for (Nota nota : todasLasNotas) {
            if (nota.getCodEstudiante().equals(codEstudiante)) {
                listaNotasEstudiante.add(nota);
            }
        }
        return listaNotasEstudiante;
    }
    // Método para eliminar una nota por su código
    public static void eliminarNota(String codNota) {
        listaNotas.removeIf(nota -> nota.getCodNota().equals(codNota));  // Eliminar si coincide el código
    }
}