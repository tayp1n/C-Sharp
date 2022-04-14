using Common;
using Test.ClassesForVM.Workers;
using Test.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ViewModel
{
	public class EditWorkersVM : OnPropertyChangedClass
	{
		private bool _isEditPerson;
		private bool _isAddPerson;
		private BasePerson _editPerson;
		private RelayCommand _editPersonCommand;
		private RelayCommand _addPersonCommand;
		private RelayCommand _cancelFullViewPersonCommand;
		private RelayCommand _saveEditPersonCommand;
		private BasePerson _selectedPerson;
		private BasePerson _selectedPersonType;
		private RelayCommand _fullViewPersonCommand;
		private bool _isFullViewPerson;

		public ObservableCollection<BasePerson> People { get; } = new ObservableCollection<BasePerson>();
		public BasePerson SelectedPerson { get => _selectedPerson; set => SetProperty(ref _selectedPerson, value); }
		public bool IsFullViewPerson { get => _isFullViewPerson; private set => SetProperty(ref _isFullViewPerson, value); }
		public bool IsEditPerson { get => _isEditPerson; private set => SetProperty(ref _isEditPerson, value); }
		public bool IsAddPerson { get => _isAddPerson; private set => SetProperty(ref _isAddPerson, value); }
		public BasePerson EditPerson { get => _editPerson; private set => SetProperty(ref _editPerson, value); }
		public ObservableCollection<BasePerson> PersonTypes { get; } = new ObservableCollection<BasePerson>()
		{
			new Intern(),
			new Worker(),
			new DepartmentHead(),
			new LowDirector(),
			new MidDirector(),
			new TopDirector()
		};
		public BasePerson SelectedPersonType { get => _selectedPersonType; set => SetProperty(ref _selectedPersonType, value); }

		public RelayCommand EditPersonCommand => _editPersonCommand
			?? (_editPersonCommand = new RelayActionCommand(EditPersonMethod, EditPersonCanMethod));

		private bool EditPersonCanMethod() => !(IsFullViewPerson || IsEditPerson || IsAddPerson || SelectedPerson == null);

		private void EditPersonMethod()
		{
			EditPerson = SelectedPerson.Clone();
			IsEditPerson = true;
			FullViewPersonMethod();
		}

		public RelayCommand AddPersonCommand => _addPersonCommand
			?? (_addPersonCommand = new RelayActionCommand(AddPersonMethod, AddPersonCanMethod));

		private bool AddPersonCanMethod() => !(IsFullViewPerson || IsEditPerson || IsAddPerson || SelectedPersonType == null);

		private void AddPersonMethod()
		{
			EditPerson = SelectedPersonType.Clone();
			IsEditPerson = true;
			IsAddPerson = true;
			FullViewPersonMethod();
		}

		public RelayCommand SaveEditPersonCommand => _saveEditPersonCommand
			?? (_saveEditPersonCommand = new RelayActionCommand(SavePersonMethod, SavePersonCanMethod));

		private bool SavePersonCanMethod() => IsEditPerson;

		private void SavePersonMethod()
		{
			if (IsAddPerson)
				People.Add(EditPerson);
			else
				EditPerson.CopyTo(SelectedPerson);
		}

		public RelayCommand FullViewPersonCommand => _fullViewPersonCommand
			?? (_fullViewPersonCommand = new RelayActionCommand(FullViewPersonMethod, FullViewCanMethod));

		private bool FullViewCanMethod() => !(IsFullViewPerson || SelectedPerson == null);


		private void FullViewPersonMethod()
		{
			if (EditPerson == null)
				EditPerson = SelectedPerson;
			IsFullViewPerson = true;
			fullViewDialog();
			EditPerson = null;
			IsEditPerson = false;
			IsAddPerson = false;
			IsFullViewPerson = false;
		}

		/// <summary>Конструктор используемый для создания
		/// Контекста Данных Времени Разработки</summary>
		public EditWorkersVM() : this(true) { }


		ModelMainDepartament model;

		/// <summary>Основной конструктор</summary>
		/// <param name="IsDesignMode"><see langword="true"/>
		/// - если VM создаётся во время Разрабки Дизайна</param>
		protected EditWorkersVM(bool IsDesignMode)
		{
			// Создание общего Контекста Данных 

			model = new ModelMainDepartament();
			model.LoadData();
			model.GetAllWorkers().ToList()
				.ForEach(person => People.Add(person));

			if (IsDesignMode)
			{
				// Создание Контекста Данных Времени Разработки
			}
			else
			{
				// Создание Контекста Данных Времени Исполнения
			}

			// Создание общего Контекста Данных 
		}

		/// <summary>Делегат вызова диалога полной показа</summary>
		/// <returns>Возвращает:
		/// <see langword="true"/> - если нажато "Сохранить",
		/// <see langword="false"/> - если "Отменить",
		/// <see langword="null"/> - если закрыт диалог без использования кнопок.</returns>
		protected Func<bool?> fullViewDialog;

		/// <summary>Конструктор используемый для создания
		/// Контекста Данных Времени Исполнения</summary>
		/// <param name="fullViewDialog">Делегат вызова диалога полной показа</param>
		public EditWorkersVM(Func<bool?> fullViewDialog) : this(false)
			=> this.fullViewDialog = fullViewDialog
			?? throw new ArgumentNullException(nameof(fullViewDialog));

	}
}
