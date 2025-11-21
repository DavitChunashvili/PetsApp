using MVP_Project.Models;
using MVP_Project.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Project.Presenters
{
    public class PetPresenter
    {
        private IPetView view;
        private IPetRepository repository;
        private BindingSource petBindingSource;
        private IEnumerable<PetModel> petList;

        //Constructor
        public PetPresenter(IPetView view, IPetRepository repository)
        {
            this.petBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe to view events
            this.view.SearchEvent += SearchPet;
            this.view.AddNewEvent += AddNewPet;
            this.view.EditEvent += LoadSelectedPetToEdit;
            this.view.DeleteEvent += DeleteSelectedPet;
            this.view.SaveEvent += SavePet;
            this.view.CancelEvent += CancelAction;
            //Set Pet List binding source
            this.view.SetPetListBindingSource(petBindingSource);
            //Load Pet list
            LoadAllPets();
            //Show view
            this.view.Show();
        }

        private void LoadAllPets()
        {
           petList = repository.GetAll();
            petBindingSource.DataSource = petList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SavePet(object? sender, EventArgs e)
        {
            var model = new PetModel();
            model.Id = Convert.ToInt32(view.PetID);
            model.Name = view.PetName;
            model.Type = view.PetType;
            model.Colour = view.PetColour;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit) //Edit pet
                {
                    repository.Edit(model);
                   
                    view.Message = "Pet edited successfully.";
                }
                else //Add new pet
                {
                    repository.Add(model);
                    
                    view.Message = "New pet added successfully.";
                }
                view.IsSuccessful = true;
                LoadAllPets();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Error occured while saving pet. " + ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.PetID = "0";
            view.PetName = "";
            view.PetType ="";
            view.PetColour = "";
           
        }

        private void DeleteSelectedPet(object? sender, EventArgs e)
        {
            try
            {
                var pet = (PetModel)petBindingSource.Current;
                repository.Delete(pet.Id);
                view.IsSuccessful = true;
                view.Message = "Pet deleted successfully.";
                LoadAllPets();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Error occured while deleting pet. " + ex.Message;
            }
        }
        private void LoadSelectedPetToEdit(object? sender, EventArgs e)
        {
            var pet  = (PetModel) petBindingSource.Current;
            view.PetID = pet.Id.ToString();
            view.PetName = pet.Name;
            view.PetType = pet.Type;
            view.PetColour = pet.Colour;
            view.IsEdit = true;
        }

        private void AddNewPet(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchPet(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                petList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                petList = repository.GetAll();
            }
            petBindingSource.DataSource = petList;
        }
    }
}
