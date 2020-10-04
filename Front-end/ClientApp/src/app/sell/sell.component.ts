import {Component, OnInit, ViewChild} from '@angular/core';
import {FormBuilder, FormGroup, Validators, FormControl} from '@angular/forms';
import {Product} from './../models/Product';
import {ActivatedRoute} from '@angular/router';
import {Observable} from 'rxjs';
import {map, startWith} from 'rxjs/operators';
import { MatStepper } from '@angular/material/stepper';
import { ProductsService } from '../services/products.service';

@Component({
  selector: 'app-sell',
  templateUrl: './sell.component.html',
  styleUrls: ['./sell.component.css']
})

export class SellComponent implements OnInit {

  sellForm: FormGroup;
  chooseProductFormGroup: FormGroup;
  productDetailsFormGroup: FormGroup;
  isEditable = false;
  products: Array<Product>;

  chosenProduct: Product ;
  filteredProducts: Observable<Product[]>;

  @ViewChild('stepper') stepper: MatStepper;

  constructor(private fb: FormBuilder,
    private route: ActivatedRoute,
    private productsService: ProductsService) {
      // this.filteredProducts = this.productIdCtrl.valueChanges
      // .pipe(
      //   startWith(''),
      //   map(product => product ? this._filterProducts(product) : this.products.slice())
      // );
    }

  ngOnInit() {

    this.createSellForm();

    this.route.data.subscribe(data => {
      this.products = data['prd_listing'];
    })


  }

  next(){

    console.log(this.sellForm);
    console.log(this.products);
    console.log(this.chooseProductFormGroup['productId']);
    this.chosenProduct = this.products.find(x => x.Id === this.chooseProductFormGroup['productId']);
    console.log(this.chosenProduct);
  }

  createSellForm(): void {


    this.chooseProductFormGroup = this.fb.group({
      productId: [null, Validators.required]
    });

    this.productDetailsFormGroup = this.fb.group({
      size: [null, Validators.required],
      condition: [null, Validators.required],
      price: [null, Validators.required]
    });

    this.sellForm = this.fb.group({
      chooseProductForm: this.chooseProductFormGroup,
      productDetailsForm: this.productDetailsFormGroup
    })
  }

  getProductName(id: number ){
    return this.products.find(x => x.Id === id).Title;
  }

  private _filterProducts(value: string): Product[] {
    const filterValue = value.toLowerCase();

    return this.products.filter(product => product.Title.toLocaleLowerCase().includes(filterValue.toLocaleLowerCase()));
  }

  }

