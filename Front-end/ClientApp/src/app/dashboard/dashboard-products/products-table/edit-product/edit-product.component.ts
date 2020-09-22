import { Component, OnInit, Input } from '@angular/core';
import {FormGroup, FormControl, Validators, FormBuilder} from '@angular/forms';
import { Brand } from 'src/app/models/brand';
import { Collection } from 'src/app/models/Collection';
import { AlertifyService } from 'src/app/services/alertify.service';
import {MatDialog} from '@angular/material/dialog';
import {ActivatedRoute} from '@angular/router';
import {DeleteDialogContentComponent} from './../delete-dialog-content/delete-dialog-content.component';
import { Product } from 'src/app/models/Product';

@Component({
  selector: 'app-edit-product',
  templateUrl: './edit-product.component.html',
  styleUrls: ['./edit-product.component.css']
})
export class EditProductComponent implements OnInit {

  editProductForm: FormGroup;
  selectedBrand: string;
  selectedCollections: Number[];
  brands: Brand[];
  collectionsList: Collection[];
  collections = new FormControl();

  @Input() product: Product;

  constructor(private fb: FormBuilder,
    private route: ActivatedRoute,
    public dialog: MatDialog) { }

  ngOnInit() {
    this.createEditProductForm();
  }

  createEditProductForm(): void {
    this.editProductForm = this.fb.group({
     id: [null],
     title: [null, [Validators.required, Validators.minLength(5), Validators.maxLength(100)]],
     description: [null, [Validators.required, Validators.minLength(40), Validators.maxLength(1000)]],
     price: [null, [Validators.required]],
     imageUrl: [null, [Validators.required]],
     brandId: [null, [Validators.required]],
     collectionIds: [[], []],
    });
  }

  openDeleteDialog(id: number) {

    this.dialog.open(DeleteDialogContentComponent,
      {data : {
        productId: id,
      }});

  }

  onSubmit(){

  }

}
