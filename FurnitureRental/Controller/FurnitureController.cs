using FurnitureRental.DAL;
using FurnitureRental.Model;
using System.Data;

namespace FurnitureRental.Controller
{
    /// <summary>
    /// Controls furniture-related operations, including searching and inventory retrieval.
    /// </summary>
    public class FurnitureController
    {
        private readonly FurnitureDbDal _furnitureDbDal;

        /// <summary>
        /// Initializes a new instance of the <see cref="FurnitureController"/> class.
        /// </summary>
        public FurnitureController()
        {
            _furnitureDbDal = new FurnitureDbDal();
        }

        /// <summary>
        /// Gets a list of all furniture items available in the system.
        /// </summary>
        /// <returns>A list of <see cref="Furniture"/> objects.</returns>
        public List<Furniture> GetAllFurniture()
        {
            return _furnitureDbDal.GetAllFurniture();
        }

        /// <summary>
        /// Retrieves a specific furniture item by its unique identifier.
        /// </summary>
        /// <param name="furnitureId">The ID of the furniture to retrieve.</param>
        /// <returns>The <see cref="Furniture"/> object if found; otherwise, null.</returns>
        public Furniture? GetFurnitureById(int furnitureId)
        {
            return _furnitureDbDal.GetFurnitureById(furnitureId);
        }

        /// <summary>
        /// Gets a list of furniture filtered by category and style IDs.
        /// </summary>
        /// <param name="categoryId">The ID of the category.</param>
        /// <param name="styleId">The ID of the style.</param>
        /// <returns>A list of <see cref="Furniture"/> matching the criteria.</returns>
        public List<Furniture> GetFurnitureByCategoryAndStyle(int? categoryId, int? styleId)
        {
            return _furnitureDbDal.GetFurnitureByCategoryAndStyle(categoryId, styleId);
        }

        /// <summary>
        /// Gets the categories.
        /// </summary>
        /// <returns></returns>
        public DataTable GetCategories()
        {
            return _furnitureDbDal.GetCategories();
        }

        /// <summary>
        /// Gets the styles.
        /// </summary>
        /// <returns></returns>
        public DataTable GetStyles()
        {
            return _furnitureDbDal.GetStyles();
        }


    }
}