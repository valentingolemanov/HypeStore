import {Component, Input, OnInit, ViewChild} from '@angular/core';
import {MatPaginator} from '@angular/material/paginator';
import {MatSort} from '@angular/material/sort';
import {MatTableDataSource} from '@angular/material/table';
import { ProductsService } from 'src/app/services/products.service';
import {Product} from '../../../models/Product';
import { animate, state, style, transition, trigger } from '@angular/animations';
import {Router} from '@angular/router';
import { AlertifyService } from 'src/app/services/alertify.service';
import {MatDialog} from '@angular/material/dialog';
import {DeleteDialogContentComponent} from '../products-table/delete-dialog-content/delete-dialog-content.component'
import { AddProductComponent } from '../add-product/add-product.component';

@Component({
    selector: 'app-products-table',
    templateUrl: './products-table.component.html',
    styleUrls: ['./products-table.component.css'],
    animations: [
      trigger('detailExpand', [
        state('collapsed', style({height: '0px', minHeight: '0'})),
        state('expanded', style({height: '*'})),
        transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
      ]),
    ],
    })

export class ProductsTableComponent implements OnInit {
   columnsToDisplay : string[] = ['Id', 'Title',  'Price', ];
   dataSource: MatTableDataSource<Product>;
   expandedElement: Product | null;

  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  @ViewChild(MatSort, {static: true}) sort: MatSort;


  isExpansionDetailRow = (index, row) => row.hasOwnProperty('detailRow');
  @Input() products: Array<Product>;

  constructor(private service: ProductsService,
    private router: Router,
    private alertify: AlertifyService,
    public dialog: MatDialog) {


    // Assign the data to the data source for the table to render
    // this.service.getAllProducts().subscribe(
    //   data => {
    //  this.products = data;
    //   },
    //   (err) => console.log(err),
    //   () => {
    //     this.dataSource = new MatTableDataSource(this.products);
    //     console.log(this.dataSource);
    //     this.dataSource.paginator = this.paginator;
    //     this.dataSource.sort = this.sort;
    //   }

    // );
  }

  ngOnInit() {
    this.dataSource = new MatTableDataSource(this.products);
        console.log(this.dataSource);
        this.dataSource.paginator = this.paginator;
        this.dataSource.sort = this.sort;
  }

  openDeleteDialog(id: number) {

    this.dialog.open(DeleteDialogContentComponent,
      {data : {
        productId: id,
      }});
  }

  openAddProductDialog() {
    const dialogRef = this.dialog.open(AddProductComponent);

    dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`);
    });
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }
}

