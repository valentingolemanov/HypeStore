import { Component, Input, OnInit } from '@angular/core';
import {
  FormGroup,
  Validators,
  FormBuilder,
  FormControl,
} from '@angular/forms';
import { Router } from '@angular/router';
import { CollectionsService } from './../../../../services/collections.service';
import { AlertifyService } from './../../../../services/alertify.service';
import { Collection } from 'src/app/models/Collection';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import {CollectionDeleteDialogComponent} from './../collection-delete-dialog/collection-delete-dialog.component';
import {MatDialog} from '@angular/material/dialog';

@Component({
  selector: 'app-edit-collection',
  templateUrl: './edit-collection.component.html',
  styleUrls: ['./edit-collection.component.css']
})
export class EditCollectionComponent implements OnInit {

  editCollectionForm: FormGroup;
  @Input() collection: Collection;

  constructor(private fb: FormBuilder,
    private dialog: MatDialog,
    private collectionsService: CollectionsService,
    private alertify: AlertifyService) { }

  ngOnInit() {
    this.createAddCollectionForm();
  }


  openDeleteDialog(id: number) {

    this.dialog.open(CollectionDeleteDialogComponent,
      {data : {
        collectionId: id,
      }});

  }

  createAddCollectionForm(): void {
    this.editCollectionForm = this.fb.group({
      name: [
        this.collection.Name,
        [
          Validators.required,
          Validators.minLength(2),
          Validators.maxLength(100),
        ],
      ],
      description: [
        this.collection.Description,
        [
          Validators.required,
          Validators.minLength(40),
          Validators.maxLength(1000),
        ],
      ],
      imageUrl: [this.collection.ImageUrl, [Validators.required]],
      homeDisplay: [this.collection.HomeDisplay, [Validators.required]],
      displayRows: [this.collection.DisplayRows, []],
      displayCols: [this.collection.DisplayCols, []],
      displayPositionIndex: [this.collection.DisplayPositionIndex, []],
    });
  }

  onSubmit(){
    this.collection = Object.assign(this.collection, this.editCollectionForm.value);
    this.collection.Id = Number(this.collection.Id);
    console.log(this.collection);
    this.collectionsService.updateCollection(this.collection).subscribe(res => {
      console.log(this.collection);
      // this.refreshTable.emit();
    },
    (err) => console.log(err),
    () => {
      this.alertify.success("Congrats, you updated this collection info!");

    });
  }
}

