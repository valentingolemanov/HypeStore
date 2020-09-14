import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {MatMenuModule} from '@angular/material/menu';
import {MatButtonModule} from '@angular/material/button';
import {MatCardModule} from '@angular/material/card';
import {MatGridListModule} from '@angular/material/grid-list'
import {HttpClientModule} from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {RouterModule, Routes} from '@angular/router';
import { FlexLayoutModule } from "@angular/flex-layout";
import { MatToolbarModule } from "@angular/material/toolbar";
import {MatFormFieldModule} from '@angular/material/form-field'
import {MatInputModule} from '@angular/material/input';
import {MatSelectModule} from '@angular/material/select';
import {ReactiveFormsModule} from '@angular/forms';
import {MatProgressBarModule} from '@angular/material/progress-bar';
import {MatIconModule} from '@angular/material/icon';
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatTabsModule} from '@angular/material/tabs';
import { MatListModule} from '@angular/material/list'
import {MatCheckboxModule} from '@angular/material/checkbox';
import {MatRadioModule} from '@angular/material/radio';
import {MatPaginatorModule} from '@angular/material/paginator';
import {MatTableModule} from '@angular/material/table';
import {MatExpansionModule} from '@angular/material/expansion';
import {MatDialogModule} from '@angular/material/dialog';
import {MatTooltipModule} from '@angular/material/tooltip';
import {MatSortModule} from '@angular/material/sort';
import {MatDividerModule} from '@angular/material/divider';
import {IvyCarouselModule} from 'angular-responsive-carousel';

import { AppComponent } from './app.component';
import { ProductDetailComponent } from './product/product-detail/product-detail.component';
import { ProductListComponent } from './product/product-list/product-list.component';
import { NavbarComponent } from './navbar/navbar.component';
import { ProductCardComponent } from './product/product-card/product-card.component';
import {ProductsService} from './services/products.service';
import {AddProductComponent} from './admin-panel/admin-products/add-product/add-product.component';
import { HomeComponent } from './home/home.component';
import { UserLoginComponent } from './user/user-login/user-login.component';
import { UserRegisterComponent } from './user/user-register/user-register.component';
import { UsersService } from './services/users.service';
import {AlertifyService} from './services/alertify.service';
import {AuthService} from './services/auth.service';
import { CatalogComponent } from './catalog/catalog.component';
import { AdminPanelComponent } from './admin-panel/admin-panel.component';
import {AdminPanelSidenavComponent} from './admin-panel/admin-panel-sidenav/admin-panel-sidenav.component';
import { AdminProductsComponent} from './admin-panel/admin-products/admin-products.component';
import {ProductsTableComponent} from './admin-panel/admin-products/products-table/products-table.component';
import {CatalogSidenavComponent} from './catalog/catalog-sidenav/catalog-sidenav.component';
import {CatalogFilterMenuComponent} from './catalog/catalog-filter-menu/catalog-filter-menu.component';
import {AddProductFormContentComponent} from './admin-panel/admin-products/add-product/add-product-form-content/add-product-form-content.component';
import {DeleteDialogContentComponent} from './admin-panel/admin-products/products-table/delete-dialog-content/delete-dialog-content.component';
import {ProductDetailsResolverService} from './services/product-details-resolver.service';
import {CollectionCardComponent} from './collection/collection-card/collection-card.component';
import {CollectionCardListingComponent} from './collection/collection-card-listing/collection-card-listing.component';


const appRoutes: Routes = [
  {path: '', component: HomeComponent},
  {path:
      'admin-products',
      component: AdminProductsComponent,
  },
  {path:
      'catalog/:id',
      component: ProductDetailComponent,
      resolve: {prd_details: ProductDetailsResolverService}},
  {path: 'login', component: UserLoginComponent},
  {path: 'register', component: UserRegisterComponent},
  {path: 'catalog', component: CatalogComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    ProductDetailComponent,
    ProductListComponent,
    NavbarComponent,
    ProductCardComponent,
    AddProductComponent,
    HomeComponent,
    UserLoginComponent,
    UserRegisterComponent,
      CatalogComponent,
      AdminPanelComponent,
      AdminPanelSidenavComponent,
      AdminProductsComponent,
      ProductsTableComponent,
      CatalogSidenavComponent,
      CatalogFilterMenuComponent,
      AddProductFormContentComponent,
      DeleteDialogContentComponent,
      CollectionCardComponent,
      CollectionCardListingComponent
   ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MatMenuModule,
    MatButtonModule,
    MatCardModule,
    MatGridListModule,
    HttpClientModule,
    RouterModule.forRoot(appRoutes),
    FlexLayoutModule,
    MatToolbarModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    ReactiveFormsModule,
    MatProgressBarModule,
    MatIconModule,
    MatSidenavModule,
    MatTabsModule,
    MatListModule,
    MatCheckboxModule,
    MatRadioModule,
    MatPaginatorModule,
    MatTableModule,
    MatExpansionModule,
    MatDialogModule,
    MatTooltipModule,
    MatSortModule,
    MatDividerModule,
    IvyCarouselModule
  ],
  providers: [ProductsService,
    UsersService,
     AlertifyService,
      AuthService,
      ProductDetailsResolverService,
      ],
  bootstrap: [AppComponent]
})
export class AppModule { }
