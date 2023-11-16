namespace EmployeeManagement.repositories;

public interface ICrudRepository<T, ID>
{
    /**
     * Devuelve todos los elementos del repositorio.
     */
    IEnumerable<T> FindAll();

    /**
     * Devuelve el elemento con el id especificado.
     * @param id Id del elemento a buscar.
     */
    T? FindById(ID id);

    /**
     * Guarda el elemento especificado en el repositorio.
     * @param element Elemento a guardar.
     */
    T? Save(T element);

    /**
     * Guarda todos los elementos especificados en el repositorio.
     * @param elements Elementos a guardar.
     */
    void SaveAll(IEnumerable<T> elements);

    /**
     * Elimina el elemento con el id especificado del repositorio.
     * @param id Id del elemento a eliminar.
     */
    bool DeleteById(ID id);

    /**
     * Elimina el elemento especificado del repositorio.
     * @param element Elemento a eliminar.
     */
    bool Delete(T element);

    /**
     * Elimina todos los elementos del repositorio.
     */
    void DeleteAll();

    /**
     * Devuelve true si existe un elemento con el id especificado en el repositorio.
     * @param id Id del elemento a buscar.
     */
    bool ExistsById(ID id);
}
